using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonExample.Data;
using PersonExample.Models;


namespace PersonExample.Repositories
{
    public class _PersonRepository : IPersonRepository
    {
        //injected database
        private readonly PersondbContext _persondbContext;

        //Define Constructor
        public _PersonRepository(PersondbContext persondbContext)
        {
            _persondbContext = persondbContext;
        }

        public Person1 Create(Person1 person1)
        {
            _persondbContext.Person1.Add(person1);
            _persondbContext.SaveChanges();
            return person1;           
        }

        public void Delete(Person1 person1)
        {
            _persondbContext.Person1.Remove(person1);
            _persondbContext.SaveChanges();
        }

        public List<Person1> Read()
        {
           var persons = _persondbContext.Person1.ToList();
            return persons;
           
        }

        public Person1 Read(string id)
        {
            var person = _persondbContext.Person1.AsNoTracking().FirstOrDefault(p =>p.Id == id);
            return person;
        }

        public Person1 Update(Person1 person1)
        {
            _persondbContext.Update(person1);
            _persondbContext.SaveChanges();
            return person1;
        }        
    }
}
