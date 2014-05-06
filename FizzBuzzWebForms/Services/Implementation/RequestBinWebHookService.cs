using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FizzBuzzWebForms.Services.Implementation
{
    public class RequestBinWebHookService : IWebHookService
    {
        public string Send(string body)
        {
            var task = MakeRequest(body);
            var response = task.Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        private static Task<HttpResponseMessage> MakeRequest(string body)
        {
            var httpClient = new HttpClient();
            return httpClient.PostAsync("http://requestb.in/1hs8tai1", new StringContent(body));
        }
    }
}