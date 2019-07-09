using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.DTOs
{
    public class CoinDTO
    {
        public int CoinId { get; set; }
        public String Name { get; set; }
        public String Symbol { get; set; }

        public int Rank { get; set; }

        public Double? Price { get; set; }

        public Double? PercentChange1h { get; set; }
        public Double? PercentChange24h { get; set; }
        public Double? PercentChange7d { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
