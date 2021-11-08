using System;
using System.Collections;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HangmanGame.CloudData
{
    public class CloudController
    {
        private HttpClient client;
        private static string uri = "https://random-word-api.herokuapp.com/word?number=1";

        public CloudController()
        {
            client = new HttpClient();
        }


        public async Task<string> GetWord()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", "NET Foundation Repository Reporter");
            var streamTask = client.GetStringAsync(uri);
            string result = await streamTask;
            //To deserialize, now it throws an error
            var finalResult = JsonConvert.DeserializeObject<string>(result);
            return finalResult;
        }
    }
}