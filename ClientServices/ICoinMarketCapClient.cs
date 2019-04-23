using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreApi.ClientServices
{
    public interface ICoinMarketCapClient
    {
        Task<HttpResponseMessage> GetLatestData();
        Task<HttpResponseMessage> ConvertPrice(string symbol = "BTC", int amount = 1, string convertTypes = "USD");
    }
}
