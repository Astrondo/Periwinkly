namespace Astrondo.Periwinkly.Client
{
    public interface IShellyHttpClient
    {
        Task<T> CallMethodAsync<T>(string method, Dictionary<string, object>? paramCollection = null);
        Task CallMethodAsync(string method, Dictionary<string, object>? paramCollection = null);
        public void SetPassword(string password);
    }

}
