using System;                  
using System.Data;

namespace MyFirstApp.API.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDbCommand CreateCommand();
        void SaveChanges();
        void RollBack();
    }
}
