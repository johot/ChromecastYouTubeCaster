using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChromecastYoutubeCaster.Test
{
    [TestClass]
    public class ChromecastYouTubeCasterTests
    {
        [TestMethod]
        public async Task Test_casting_integration_test()
        {
            // *** For now use the Google home app to find your ip or use a library like SharpCaster ***
            ChromecastYouTubeCaster chromecastYouTubeCaster = new ChromecastYouTubeCaster("192.168.1.235");

            var resp = await chromecastYouTubeCaster.PlayVideo("RDfjXj5EGqI");

            Assert.IsTrue(resp.IsSuccessStatusCode);
        }
    }
}
