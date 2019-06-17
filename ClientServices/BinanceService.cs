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
        public Task<HttpResponseMessage> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
