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
        {   //1. INSERT Lisätään henkilö PERSON-tauluun
            //2. SELECT luetaan ja otetaan talteen uuden henkilön ID
            //3. INSERT lisätään puhelinnumerot PHONE -tauluun viiteavaimen käytetään
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
        {   //SELCECT *FROM  PERSON
            //LEFT INTER JOIN
            //Phone ON Person.Id = Phone.PersonId
            //WHERE Person.Id = "SELECT ..."
            var persons = _persondbContext.Person1

                 .Include(p => p.Phone)
                 .ToList();
            return persons;           
        }

        public Person1 Read(string id)
        {
            var person = _persondbContext.Person1
                .Include(p => p.Phone)
                .AsNoTracking().FirstOrDefault(p => p.Id == id);
                 
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
