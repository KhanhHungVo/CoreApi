using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace CoreApi.ClientServices
{
    public class CoinMarketCapClient : ICoinMarketCapClient
    {
        private string COIN_MARKET_API_KEY = "b447a55c-e07c-4926-92e7-80ecc22aa461";
        public HttpClient _client { get; private set; }

        public CoinMarketCapClient(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
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
        public async Task<HttpResponseMessage> ConvertPrice(string symbol = "BTC", int amount = 1, string convertTypes = "USD")
        {
            UriBuilder builder = new UriBuilder("https://pro-api.coinmarketcap.com/v1/tools/price-conversion");
            var queryString = HttpUtility.ParseQueryString(builder.Query);
            queryString["amount"] = "1";
            queryString["symbol"] = "ETH";
            queryString["convert"] = "USD";
            builder.Query = queryString.ToString();
            return await _client.GetAsync(builder.ToString());
        }
    }
}
