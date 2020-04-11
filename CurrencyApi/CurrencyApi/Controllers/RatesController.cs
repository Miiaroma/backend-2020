using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyApi.Models;
using CurrencyApi.Repositories;
using CurrencyApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyApi.Controllers
{
    [Route("api/rates")]
    [ApiController]
    public class RatesController : ControllerBase
    {
        private readonly IRateService _rateService;
        private readonly IRateRepository _rateRepository;

        public RatesController(IRateService rateService, IRateRepository rateRepository)
        {
            _rateService = rateService;
            _rateRepository = rateRepository;
        }
        
        // GET: api/Rates
        [HttpGet]
        public IActionResult Get()
        {
            var result = _rateService.Read();
            return new JsonResult(result);
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Rates/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            var result = _rateService.Read(id);
            return new JsonResult(result);
        }

        // POST: api/Rates
        [HttpPost]
        public IActionResult Post([FromBody] RATE rate)
        {
            var result = _rateService.Create(rate);
            return new JsonResult(result);
        }

        // PUT: api/Rates/5
        [HttpPut("{id}")]
        public ActionResult<RATE> Put(string id, RATE rate)
        {
            var updatedRate = _rateService.Update(id, rate);
            return updatedRate;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }     
}
