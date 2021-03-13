using Template.Common.Config;
using Template.Core.Clients;
using Template.Core.Enums;
using Template.Core.Problems;
using Template.Core.Services.DTOs.Clients;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static Template.Core.Services.DTOs.Clients.Kernel.UserDTO;

namespace Template.Services.Services.Clients
{
    public class HTTPClientHelper : IHTTPClientHelper
    {
        IHttpClientFactory httpClientFactory;
        HttpClient client;
        String ClientName;
        private IMemoryCache _cache;
        private readonly IOptions<NovaSettings> _novaSettings;

        public HTTPClientHelper(IHttpClientFactory httpClientFactory, string ClientName, IMemoryCache memoryCache, IOptions<NovaSettings> novaSettings)
        {
            this.httpClientFactory = httpClientFactory;
            this.ClientName = ClientName;
            _cache = memoryCache;
            _novaSettings = novaSettings;
        }

        #region Generic, Async, static HTTP functions for GET, POST, PUT, and DELETE             

        public async Task<T> GetAsync<T>(string url)
        {
            T data;
            client = httpClientFactory.CreateClient(ClientName);
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                using (HttpContent content = response.Content)
                {
                    string d = await content.ReadAsStringAsync();
                    if (d != null)
                    {
                        data = JsonConvert.DeserializeObject<T>(d);
                        return (T)data;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            Object o = new Object();
            return (T)o;
        }

        public async Task<T> PostAsync<T>(string url, HttpContent contentPost)
        {
            T data;
            client = httpClientFactory.CreateClient(ClientName);

            string Token = await getToken();
            client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", Token);
            using (HttpResponseMessage response = await client.PostAsync(url, contentPost))
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        string d = await content.ReadAsStringAsync();
                        if (d != null)
                        {
                            data = JsonConvert.DeserializeObject<T>(d);
                            return (T)data;
                        }
                    }

                }
                else
                {
                    using (HttpContent content = response.Content)
                    {
                        string d = await content.ReadAsStringAsync();
                        if (d != null)
                        {
                            var ErrorData = JsonConvert.DeserializeObject<ErrorClientDTO>(d);
                            await ExceptionClient(ErrorData);
                        }
                    }
                }
                Object o = new Object();
                return (T)o;
            }
        }

        public async Task<T> PutAsync<T>(string url, HttpContent contentPut)
        {
            T data;
            client = httpClientFactory.CreateClient(ClientName);

            string Token = await getToken();
            client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", Token);
            using (HttpResponseMessage response = await client.PutAsync(url, contentPut))
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        string d = await content.ReadAsStringAsync();
                        if (d != null)
                        {
                            data = JsonConvert.DeserializeObject<T>(d);
                            return (T)data;
                        }
                    }

                }
                else
                {
                    using (HttpContent content = response.Content)
                    {
                        string d = await content.ReadAsStringAsync();
                        if (d != null)
                        {
                            var ErrorData = JsonConvert.DeserializeObject<ErrorClientDTO>(d);
                            await ExceptionClient(ErrorData);
                        }
                    }
                }
                Object o = new Object();
                return (T)o;
            }
        }

        public async Task<T> DeleteAsync<T>(string url)
        {
            T newT;
            client = httpClientFactory.CreateClient(ClientName);

            using (HttpResponseMessage response = await client.DeleteAsync(url))
            using (HttpContent content = response.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    newT = JsonConvert.DeserializeObject<T>(data);
                    return newT;
                }
            }
            Object o = new Object();
            return (T)o;
        }
        #endregion




        private async Task<string> getToken()
        {

            if (!_cache.TryGetValue("Token", out string cacheEntry))
            {
                var TokenDTO = await callTokenApi();
                // Key not in cache, so get data.
                cacheEntry = TokenDTO.id_token;

                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    // Set cache entry size by extension method.
                    .SetSize(1)
                    // Keep in cache for this time, reset time if accessed.
                    .SetSlidingExpiration(TimeSpan.FromSeconds(TokenDTO.ExpireIn));

                // Set cache entry size via property.
                // cacheEntryOptions.Size = 1;

                // Save data in cache.
                _cache.Set("Token", cacheEntry, cacheEntryOptions);
            }

            return cacheEntry;



        }


        private async Task<UserLoginResponse> callTokenApi()
        {
            UserLogin userLogin = new UserLogin()
            {
                ApplicationID = _novaSettings.Value.ClientToken.ApplicationID,
                Password = _novaSettings.Value.ClientToken.Password,
                UserName = _novaSettings.Value.ClientToken.UserName
            };
            string json = JsonConvert.SerializeObject(userLogin, Formatting.Indented);
            var httpContent = new StringContent(json, Encoding.UTF8,
                                    "application/json");
            client = httpClientFactory.CreateClient(ClientName);
            using (HttpResponseMessage response = await client.PostAsync("api/Identity", httpContent))
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        string d = await content.ReadAsStringAsync();
                        if (d != null)
                        {
                            var data = JsonConvert.DeserializeObject<UserLoginResponse>(d);
                            return data;
                        }
                    }

                }
                else
                {
                    using (HttpContent content = response.Content)
                    {
                        string d = await content.ReadAsStringAsync();
                        if (d != null)
                        {
                            var ErrorData = JsonConvert.DeserializeObject<ErrorClientDTO>(d);

                         await   ExceptionClient(ErrorData);
                        }
                    }
                  
                }


            }
            return null;
        }




        private async Task ExceptionClient(ErrorClientDTO errorClientDTO)
        {
            if (errorClientDTO.status == 401)
                _cache.Remove("Token");

            throw new HTTPClientException("Client Exception", errorClientDTO.status, errorClientDTO.detail == null ? "" : errorClientDTO.detail.ToString(), errorClientDTO.errorcode==null?Enums.ErroreCode.CLIENT_ERROR.ToString():errorClientDTO.errorcode);
        }
    }



    //public interface IHTTPClientHelper
    //{
    //    async Task<T> GetAsync<T>(string url);
    //}
}
