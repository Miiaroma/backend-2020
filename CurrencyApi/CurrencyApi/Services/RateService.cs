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

        /*public RATE Read(string id)
        {
            var rate = _rateRepository.Read(id);
            return rate;
        }*/

        public RATE Read(string country)
        {
            var rate = _rateRepository.Read(country);
            return rate;
        }

        public decimal Read(decimal amount, string sourceCountry, string targetCountry)
        {
            var sourceRate = this.Read(sourceCountry);
            var targetRate = this.Read(targetCountry);

            if (sourceRate != null && targetRate != null && amount != 0)
            {
                var result = amount * (sourceRate.Rate1 / targetRate.Rate1);
                return (decimal)result;
            }
            else
            {
                return 0;
            }
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
