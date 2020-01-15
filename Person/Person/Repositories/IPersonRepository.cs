using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonExample.Models;

namespace PersonExample.Repositories
{
    public interface IPersonRepository
    {
        Person1 Create(Person1 person1);
        List<Person1> Read();
        Person1 Read(string id);
        Person1 Update(Person1 person1);
        void Delete(Person1 person1);
    }
}    