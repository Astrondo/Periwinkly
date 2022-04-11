using Astrondo.Periwinkly.Models.HttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Client
{
    public partial class ShellyHttpClient : IShellyHttpClient
    {
        HttpClient _httpClient;
        static Random _random = new Random();
        public ShellyHttpClient(string ipAddress, string? password = null, string? proxyUrl = null)
        {
            var httpClientHandler = new HttpClientHandler();
            if (!string.IsNullOrEmpty(proxyUrl))
            {
                var proxy = new WebProxy
                {
                    Address = new Uri(proxyUrl)
                };

                httpClientHandler.Proxy = proxy;
            }
            _httpClient = new HttpClient(httpClientHandler, true);

            shellyRPCEndpointURL = $"http://{ipAddress}/rpc";

            _password = password;
        }
        private string shellyRPCEndpointURL;
        private string _password;
        private ShellySessionAuthModel _shellyAuthRequirements;
        private long request_id = 0;

        public async Task<T> CallMethodAsync<T>(string method, Dictionary<string, object>? paramCollection = null)
        {
            return await CallMethodAsync<T>(new ShellyRPCModel() { Method = method, Params = paramCollection });
        }

        public async Task<T> CallMethodAsync<T>(ShellyRPCModel requestModel)
        {
            var response = await MakeRequest(requestModel);

            var wrapped = await response.Content.ReadFromJsonAsync<ShellyRPCResponseModel<T>>(JsonSettings);
            return wrapped.Result;
        }

        public async Task CallMethodAsync(string method, Dictionary<string, object>? paramCollection = null)
        {
            var response = await MakeRequest(new ShellyRPCModel() { Method = method, Params = paramCollection });
            var raw = await response.Content.ReadAsStringAsync();

        }

        private JsonSerializerOptions JsonSettings = new System.Text.Json.JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,

            PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
            Converters =
            {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
            }
        };

        private async Task<HttpResponseMessage> MakeRequest(ShellyRPCModel requestModel)
        {
            var myRequestId = Interlocked.Increment(ref request_id);
            requestModel.Id = myRequestId;

            requestModel.Params = requestModel.Params?.Where(x => x.Value != null).ToDictionary(x => x.Key, x => x.Value);
            if (!string.IsNullOrEmpty(_password) && _shellyAuthRequirements != null)
            {
                requestModel.Auth = CreateAuthModel(_password, _shellyAuthRequirements);
            }
            var postRequest = new HttpRequestMessage(HttpMethod.Post, shellyRPCEndpointURL)
            {
                Content = JsonContent.Create(requestModel, null, JsonSettings)
            };


            var postResponse = await _httpClient.SendAsync(postRequest);
            if (postResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                if (string.IsNullOrEmpty(_password))
                {
                    throw new Exception("Shelly device requires a password.");
                }
                else
                {
                    _shellyAuthRequirements = ParseShellyAuthRequest(postResponse);
                    if (!string.IsNullOrEmpty(_password) && _shellyAuthRequirements != null)
                    {
                        requestModel.Auth = ShellyHttpClient.CreateAuthModel(_password, _shellyAuthRequirements);
                    }
                    postRequest = new HttpRequestMessage(HttpMethod.Post, shellyRPCEndpointURL)
                    {
                        Content = JsonContent.Create(requestModel, null, JsonSettings)
                    };
                    postResponse = await _httpClient.SendAsync(postRequest);
                }
            }
            postResponse.EnsureSuccessStatusCode();
            return postResponse;
        }

        private ShellySessionAuthModel? ParseShellyAuthRequest(HttpResponseMessage postResponse)
        {
            //qop="auth", realm="shellypro1-30c6f7849da4", nonce="62519f86", algorithm=SHA-256

            var str = postResponse.Headers.WwwAuthenticate.First().Parameter;
            var fieldStrs = str.Split(new string[] { ", " }, StringSplitOptions.None);
            var fields = new Dictionary<string, string>();
            foreach (var field in fieldStrs)
            {
                var split = field.Split('=');
                var key = split[0];
                var value = split[1];
                value = value.Trim().Trim('"');
                fields.Add(key, value);
            }
            var model = new ShellySessionAuthModel()
            {
                Algorithm = fields["algorithm"],
                Nonce = fields["nonce"],
                Realm = fields["realm"]
            };
            return model;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }
        public static ShellyRPCAuthModel CreateAuthModel(string password, ShellySessionAuthModel shellyAuthRequirements)
        {
            var nonce = Convert.ToInt64(shellyAuthRequirements.Nonce, 16);
            var cNonce = _random.Next(1000000);
            return CreateAuthModel(password, shellyAuthRequirements.Realm, nonce, cNonce, "admin", "SHA-256");
        }
        public static ShellyRPCAuthModel CreateAuthModel(string password, string realm, long nonce, long cNonce, string username, string algo)
        {
            var authModel = new ShellyRPCAuthModel();
            authModel.Realm = realm;
            authModel.Algorithm = algo;
            authModel.Nonce = nonce;
            authModel.Username = username;
            authModel.Cnonce = cNonce;

            var ha1 = $"{username}:{realm}:{password}";
            var ha2 = "dummy_method:dummy_uri";
            using (SHA256 hash = SHA256.Create())
            {
                var ha1Hashed = HashString(hash, ha1);
                var ha2Hashed = HashString(hash, ha2);
                var unHashedString = $"{ha1Hashed}:{nonce}:1:{cNonce}:auth:{ha2Hashed}";

                authModel.Response = HashString(hash, unHashedString);
            }

            return authModel;
        }
        private static string HashString(SHA256 hasher, string unHashedString)
        {
            Byte[] result = hasher.ComputeHash(Encoding.UTF8.GetBytes(unHashedString));
            StringBuilder Sb = new StringBuilder();

            foreach (Byte b in result)
                Sb.Append(b.ToString("x2"));
            return Sb.ToString();
        }
    }
}
