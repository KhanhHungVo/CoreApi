using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.DTOs.CoinMarketResModels
{
    public class CoinMarketRes
    {
        public Status status { get; set; }
        public List<Coin> data { get; set; }
    }
}
