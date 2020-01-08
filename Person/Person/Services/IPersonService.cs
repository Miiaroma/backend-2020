using PersonExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonExample.Services
{
    public interface IPersonService
    {
        List<Person1> Read();
        Person1 Read(string id);
    }
}
