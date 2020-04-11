using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyApi.Models;

namespace CurrencyApi.Repositories
{
    public interface IRateRepository
    {
        RATE Create(RATE rate);
        List<RATE> Read();
        RATE Read(string id);
        RATE Update(RATE rate);
    }
}
