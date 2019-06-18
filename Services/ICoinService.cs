using CoreApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Services
{
    public interface ICoinService
    {
        Coin Create(Coin coin);
    }
}
