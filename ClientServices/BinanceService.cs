using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreApi.ClientServices
{
    public class BinanceService : IBinanceService
    {
        private static string API_KEY = "";
        public HttpClient _client { get; private set; }
        public BinanceService(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", API_KEY);
            _client = httpClient;
        }
        public Task<HttpResponseMessage> GetLatestData()
        {

            throw new NotImplementedException();
            
        }
    }
}
