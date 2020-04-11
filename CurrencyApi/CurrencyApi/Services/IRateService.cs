using CurrencyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyApi.Services
{
    public interface IRateService
    {
        RATE Create(RATE rate);
        List<RATE> Read();
        RATE Read(string id);
        RATE Update(string id, RATE rate);
    }
}
