using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChromecastYoutubeCaster
{
    // Some good info: http://fiquett.com/2013/07/chromecast-traffic-sniffing/

    public class ChromecastYouTubeCaster
    {
        private readonly string _chromecastIp;

        public ChromecastYouTubeCaster(string chromecastIp)
        {
            _chromecastIp = chromecastIp;
        }

        /// <summary>
        /// VideoId is this part: https://www.youtube.com/watch?v={videoId}
        /// </summary>
        /// <param name="videoId"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> PlayVideo(string videoId)
        {
            var client = new HttpClient();
            var httpContent = new StringContent($"v={videoId}", Encoding.UTF8, "application/json");

            // Get the response.
            var url = "http://" + _chromecastIp + ":8008/apps/YouTube";

            HttpResponseMessage response = await client.PostAsync(url, httpContent);

            return response;
        }
    }
}
