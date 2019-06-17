using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreApi.ClientServices
{
    public interface ICoinMarketCapService
    {
        Task<HttpResponseMessage> GetData();
    }
}
