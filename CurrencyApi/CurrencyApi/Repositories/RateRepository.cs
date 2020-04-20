using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CurrencyApi.Data;
using CurrencyApi.Models;


namespace CurrencyApi.Repositories
{
    public class _RateRepository : IRateRepository
    {
        private readonly Dtbankdb1Context _dtbankdb1Context;

        public _RateRepository(Dtbankdb1Context dtbankdb1Context)
        {
            _dtbankdb1Context = dtbankdb1Context;
        }

        public RATE Create(RATE rate)
        {
            _dtbankdb1Context.RATE.Add(rate);
            _dtbankdb1Context.SaveChanges();
            return rate;            
        }

        /*public RATE Read(string id)
        {
            var rate = _dtbankdb1Context.RATE.
                AsNoTracking().FirstOrDefault(p => p.Id == id);
            return rate;
        }*/

        public RATE Read(string country)
        {
            var rate = _dtbankdb1Context.RATE.
                AsNoTracking().FirstOrDefault(p => p.Country == country);
            return rate;
        }
        public List<RATE> Read()
        {
            var rates = _dtbankdb1Context.RATE                 
                 .ToList();
            return rates;
        }
             
        public RATE Update(RATE rate)
        {
            _dtbankdb1Context.Update(rate);
            _dtbankdb1Context.SaveChanges();
            return rate;
        }   
    }
}
