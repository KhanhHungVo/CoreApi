using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace CoreApi.ClientServices
{
    public class CoinMarketCapService : BaseHttpClientService, ICoinMarketCapService
    {
        private string COIN_MARKET_API_KEY = "b447a55c-e07c-4926-92e7-80ecc22aa461";

        private HttpClient _client { get; set; }

        public CoinMarketCapService(HttpClient httpClient) : base(httpClient)
        {
            httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", COIN_MARKET_API_KEY);
            _client = httpClient;
        }

        // List all cryptocurrencies (latest)
        public async Task<HttpResponseMessage> GetLatestData()
        {
            UriBuilder builder = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");
            var queryString = HttpUtility.ParseQueryString(builder.Query);
            queryString["start"] = "1";
            queryString["limit"] = "5000";
            queryString["convert"] = "USD";
            builder.Query = queryString.ToString();
            return await _client.GetAsync(builder.ToString());
        }

        // Convert price
        public async Task<HttpResponseMessage> ConvertPrice(string symbol, int amount, string convertTypes)
        {
            UriBuilder builder = new UriBuilder("https://pro-api.coinmarketcap.com/v1/tools/price-conversion");
            var queryString = HttpUtility.ParseQueryString(builder.Query);
            queryString["symbol"] = symbol;
            queryString["amount"] = amount.ToString();
            queryString["convert"] = convertTypes;
            builder.Query = queryString.ToString();
            return await _client.GetAsync(builder.ToString());
        }
    }
}
