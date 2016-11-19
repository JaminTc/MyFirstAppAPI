using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.API.Data.Helpers;
using MyFirstApp.API.Data.Interfaces;
using MyFirstApp.API.DomainModel;

namespace MyFirstApp.API.Data.Repositories
{
    internal class PersonRepository : DbRepositoryBase, IPersonRepository
    {
        public PersonRepository(IUnitOfWorkFactory uowFactory) : base(uowFactory) { }

        public Person GetPerson(Person person)
        {
            const string spName = "GetPerson";
            Person newPerson = new Person();
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                using (var cmd = unitOfWork.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = spName;
                    cmd.Parameters.Add(new SqlParameter("@PersonId",person.Id));

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            newPerson.DateOfBirth = rdr.DBHelper().GetDateTimeValue("DateOfBirth");
                            newPerson.FirstName = rdr.DBHelper().GetStringValue("FirstName");
                            newPerson.LastName = rdr.DBHelper().GetStringValue("LastName");
                            newPerson.Id = rdr.DBHelper().GetIntValue("PersonId");
                        }
                    }
                }
            }
            return newPerson;
        }
    }
}
