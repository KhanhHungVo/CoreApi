using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreApi.ClientServices
{
    public class BinanceService : BaseHttpClientService, IBinanceService
    {
        private static string API_KEY = "";
        public HttpClient _client { get; private set; }
        public BinanceService(HttpClient httpClient): base(httpClient)
        {
            httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", API_KEY);
            _client = httpClient;
        }
        public Task<HttpResponseMessage> GetLatestData()
        {

            throw new NotImplementedException();
            
        }
    }
}
