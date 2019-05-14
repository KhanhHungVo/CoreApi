using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreApi.Helper
{
    public class CurrencyConvert
    {
        private string CURRENCY_CONVERT_API_KEY = "b447a55c-e07c-4926-92e7-80ecc22aa461";
        public HttpClient _client { get; private set; }

        public CurrencyConvert(HttpClient httpClient)
        {
            
        }
    }
}
