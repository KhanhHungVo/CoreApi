using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using CoreApi.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CoreApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Coin")]
    public class CoinController : ControllerBase
    {
        private static string API_KEY = "b447a55c-e07c-4926-92e7-80ecc22aa461";
        public static HttpClient client = new HttpClient();
        public async Task<ActionResult> Test()
        {
            var result = "";
            UriBuilder builder = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");
            var queryString =  HttpUtility.ParseQueryString(builder.Query);
            queryString["start"] = "1";
            queryString["limit"] = "5000";
            queryString["convert"] = "USD";
            builder.Query = queryString.ToString();
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", API_KEY);

            HttpResponseMessage responseMessage = await httpClient.GetAsync(builder.ToString());

            // Serialize data
            if(responseMessage.IsSuccessStatusCode)
            {
               result = await responseMessage.Content.ReadAsStringAsync();
            }
            var obj = JsonConvert.DeserializeObject<object>(result);
            return Ok(obj);
     
        }
    }
}