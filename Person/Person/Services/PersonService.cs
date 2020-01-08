using PersonExample.Models;
using PersonExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonExample.Services
{
    
    public class PersonService : IPersonService
    {   //Inject Repository layer
        private readonly IPersonRepository _personRepository;

        //Define Constructor
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        

        public List<Person1> Read()
        {
            var persons = _personRepository.Read();
            return persons;

        }

        public Person1 Read(string id)
        {
            var person = _personRepository.Read(id);
            return person;
        }
    }
}

