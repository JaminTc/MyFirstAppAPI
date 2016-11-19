using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.API.Data.Interfaces;

namespace MyFirstApp.API.Data.Factories
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly string _connectionString;
        private readonly bool _ownsConnection;

        public UnitOfWorkFactory(string connectionString, bool ownsConnection)
        {
            _connectionString = connectionString;
            _ownsConnection = ownsConnection;
        }

        public IUnitOfWork Create()
        {
            return new UnitOfWork(new SqlConnection(_connectionString), _ownsConnection);
        }
    }
}
