using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.API.DomainModel;

namespace MyFirstApp.API.Buisness.Interfaces
{
    public interface IPersonManager
    {
        Person GetPerson(Person person);
    }
}
