using Finances.App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using HttpClientNative = System.Net.Http.HttpClient;

namespace Finances.App.Helpers
{
    public class HttpClient
    {
        string baseUrl;
        
        readonly HttpClientNative client;

        public HttpClient()
        {
            baseUrl = "http://localhost:5001/";
            client = new HttpClientNative();

            ConfigureClient();
        }

        public async void ConfigureClient()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", await SecureStorage.GetAsync("jwtToken"));
        }

        public async Task<JsonDefaultResponse<T>> Get<T>(string endpoint)
        {
            string response = await client.GetStringAsync(endpoint);

            var a = JsonTransformer.Deserialize<JsonDefaultResponse<T>>(response);
            return a;
        }

        public async Task<JsonDefaultResponse<T>> Delete<T>(string endpoint)
        {
            HttpResponseMessage message = await client.DeleteAsync(endpoint);
            string response = message.Content.ReadAsStringAsync().Result;
            return JsonTransformer.Deserialize<JsonDefaultResponse<T>>(response);
        }

        public async Task<JsonDefaultResponse<T>> Post<T>(string endpoint, object content)
        {
            StringContent stringContent = new StringContent(JsonTransformer.Serialize(content), Encoding.UTF8, "application/json");
            HttpResponseMessage request = await client.PostAsync(endpoint, stringContent);
            string response = request.Content.ReadAsStringAsync().Result;
            return JsonTransformer.Deserialize<JsonDefaultResponse<T>>(response);
        }

        public async Task<JsonDefaultResponse<T>> Put<T>(string endpoint, object content)
        {
            StringContent stringContent = new StringContent(JsonTransformer.Serialize(content), Encoding.UTF8, "application/json");
            HttpResponseMessage request = await client.PutAsync(endpoint, stringContent);
            string response = request.Content.ReadAsStringAsync().Result;
            return JsonTransformer.Deserialize<JsonDefaultResponse<T>>(response);
        }

        public async Task<JsonDefaultResponse<T>> Patch<T>(string endpoint, object content)
        {
            StringContent stringContent = new StringContent(JsonTransformer.Serialize(content), Encoding.UTF8, "application/json");
            HttpRequestMessage requestContent = new HttpRequestMessage(new HttpMethod("PATCH"), endpoint)
            {
                Content = stringContent
            };
            HttpResponseMessage request = await client.SendAsync(requestContent);
            string response = request.Content.ReadAsStringAsync().Result;
            return JsonTransformer.Deserialize<JsonDefaultResponse<T>>(response);
        }
    }
}
