using CryptoModule.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoModule.Services
{
    public class APIService : IAPIService
    {
        private string baseUrl = "https://pro-api.coinmarketcap.com";
        private string header = "/v1/cryptocurrency/listings/latest?";
        private string apiKey = "CMC_PRO_API_KEY=8c0ed700-b255-4a8e-976b-3035cf4c51a9";

        public async Task<Response> GetCryptoInfo()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(baseUrl);

                var response = await client.GetAsync($"{header}{apiKey}");
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result
                    };
                }

                var apiInfo = JsonConvert.DeserializeObject<Crypto>(result);

                if(apiInfo == null)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result
                    };
                }

                return new Response
                {
                    IsSuccess = true,
                    Result = apiInfo
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
