using Astrondo.Periwinkly.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Astrondo.Periwinkly.Tests
{
    [TestClass]
    public class AuthTests
    {
        [TestMethod]
        public void TestAuthenticationHasher()
        {
            var result = ShellyHttpClient.CreateAuthModel("password", "shellypro1-30c6f7849da4", 1649523350, 1649523352450, "admin", "SHA-256");
            Assert.AreEqual("1aa5ff74be67278159e12165546acf59fc6b8bb8a6f0bf42f0f8497519c12e0e", result);
        }
    }
}