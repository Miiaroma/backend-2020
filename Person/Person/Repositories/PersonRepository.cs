using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonExample.Data;
using PersonExample.Models;

namespace PersonExample.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        //injected database
        private readonly PersondbContext _persondbContext;

        //Define Constructor
        public PersonRepository(PersondbContext persondbContext)
        {
            _persondbContext = persondbContext;
        }

        public List<Person1> Read()
        {
           var persons = _persondbContext.Person1.ToList();
            return persons;
           
        }

        public Person1 Read(string id)
        {
            var person = _persondbContext.Person1.FirstOrDefault(p =>p.Id == id);
            return person;
        }
    }
}
