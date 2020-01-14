using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonExample.Data;
using PersonExample.Models;
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
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonService personService, IPersonRepository personRepository)
        {
            _personService = personService;
            _personRepository = personRepository;
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
        public IActionResult Post([FromBody] Person1 person1)
        {
            var result = _personService.Create(person1);
            return new JsonResult(result);
        }
        
        // PUT: api/Persons/5
        [HttpPut("{id}")]
        public IActionResult Put( [FromBody] Person1 person1)
        {
            var result = _personService.Update(person1);
            return new JsonResult(result);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _personService.Delete(id);
        }
    }
}
