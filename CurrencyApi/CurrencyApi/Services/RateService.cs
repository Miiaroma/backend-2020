using CurrencyApi.Models;
using CurrencyApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyApi.Services
{
    public class _RateService : IRateService
    {
        private readonly IRateRepository _rateRepository;

        public _RateService(IRateRepository rateRepository)
        {
            _rateRepository = rateRepository;
        }

        public RATE Create(RATE rate)
        {
            return _rateRepository.Create(rate);
        }

        public List<RATE> Read()
        {
            var rates = _rateRepository.Read();
            return rates;
        }

        public RATE Read(string id)
        {
            var rate = _rateRepository.Read(id);
            return rate;           
        }

        public RATE Update(string id, RATE rate)
        {
            var updatedPerson = _rateRepository.Read(id);
            if (updatedPerson == null)
            {
                throw new Exception("Rate not found!");
            }
            else
            {
                return _rateRepository.Update(rate);
            }
            
        }
    }
}
