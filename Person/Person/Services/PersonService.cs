using PersonExample.Models;
using PersonExample.Repositories;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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

        public Person1 Create(Person1 person1)
        {
            return _personRepository.Create(person1);
        }

        public void Delete(string id)
        {
            Person1 removedPerson = _personRepository.Read(id);
            _personRepository.Delete(removedPerson);
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

        public Person1 Update(string id, Person1 person1)
        {
            var updatedPerson = _personRepository.Read(id);
            if (updatedPerson == null)
            {
                throw new Exception("Person not found!");
            }
            else
            {
                return _personRepository.Update(person1);
            }
        }

        
    }
}

