using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreApi.ClientServices
{
    interface IBinanceService
    {
        Task<HttpResponseMessage> GetLatestData();
    }
}
