using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonExample.Data;
using PersonExample.Repositories;
using PersonExample.Services;

namespace Person.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //Inject Repository
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }


        // GET: api/Persons
        [HttpGet]
        public IActionResult Get()
        {
            var result = _personService.Read();
            return new JsonResult(result);
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Persons/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            var result = _personService.Read(id);
            return new JsonResult(result);
        }

        // POST: api/Persons
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Persons/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
