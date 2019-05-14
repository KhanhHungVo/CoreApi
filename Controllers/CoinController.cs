using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using CoreApi.ClientServices;
using CoreApi.DTOs.CoinMarketResModels;
using CoreApi.Entities;
using CoreApi.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CoreApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class CoinController : ControllerBase
    {
        //private static string API_KEY = "b447a55c-e07c-4926-92e7-80ecc22aa461";
        //public static HttpClient client = new HttpClient();
        private readonly ICoinMarketCapClient _coinMarketClient;
        public CoinController(ICoinMarketCapClient coinMarketClient)
        {
            _coinMarketClient = coinMarketClient;
        }

        [HttpGet]
        public async Task<ActionResult> Test()
        {
            var result = "";
            //UriBuilder builder = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");
            //var queryString =  HttpUtility.ParseQueryString(builder.Query);
            //queryString["start"] = "1";
            //queryString["limit"] = "5000";
            //queryString["convert"] = "USD";
            //builder.Query = queryString.ToString();
            //var httpClient = new HttpClient();
            //httpClient.DefaultRequestHeaders.Accept.Clear();
            //httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", API_KEY);

            //HttpResponseMessage responseMessage = await httpClient.GetAsync(builder.ToString());

            HttpResponseMessage res = await _coinMarketClient.GetLatestData();

            // Serialize data
            if(res.IsSuccessStatusCode)
            {
               result = await res.Content.ReadAsStringAsync();
               var resultData = JsonConvert.DeserializeObject<CoinMarketRes>(result);
                return Ok(resultData);
            }
            return BadRequest(res);
        }

        [HttpGet("convert")]
        public async Task<ActionResult> ConvertPrice()
        {
            var result = "";
            HttpResponseMessage res = await _coinMarketClient.ConvertPrice("BTC");

            // Serialize data
            if (res.IsSuccessStatusCode)
            {
                result = await res.Content.ReadAsStringAsync();
                var resultData = JsonConvert.DeserializeObject<CoinMarketRes>(result);
                return Ok(resultData);
            }
            return BadRequest(res);

        }
    }
}