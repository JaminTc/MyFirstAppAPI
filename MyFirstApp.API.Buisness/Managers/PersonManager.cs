using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.API.Buisness.Interfaces;
using MyFirstApp.API.Data.Interfaces;
using MyFirstApp.API.DomainModel;

namespace MyFirstApp.API.Buisness.Managers
{
    internal class PersonManager : RepositoryManager<IPersonRepository>, IPersonManager
    {
        public PersonManager(IPersonRepository repo) : base(repo) { }

        public Person GetPerson(Person person)
        {
            return _repository.GetPerson(person);
        }
    }
}
