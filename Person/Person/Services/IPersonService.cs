using PersonExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonExample.Services
{
    public interface IPersonService
    {
        Person1 Create(Person1 person1);  
        List<Person1> Read();
        Person1 Read(string id);
        Person1 Update(string id, Person1 person1);
        void Delete(string id);
    }
}
