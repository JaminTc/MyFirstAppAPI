using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.API.Data.Interfaces;

namespace MyFirstApp.API.Data
{
    internal class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private readonly bool _ownsConnection;
        private IDbTransaction _transaction;
        private bool _disposed;

        public UnitOfWork(IDbConnection conncetion, bool ownsConnection)
        {
            _connection = conncetion;
            _ownsConnection = ownsConnection;
            _connection.Open();
            _transaction = conncetion.BeginTransaction();
        }
        public IDbCommand CreateCommand()
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;
            return command;
        }
        public void SaveChanges()
        {
            if (_transaction == null)
                throw new InvalidOperationException("Transaction have already been commited. Check your transaction handling");

            _transaction.Commit();
            _transaction = null;
        }
        public void RollBack()
        {
            if (_transaction == null)
                return;
            _transaction.Rollback();
            _transaction = null;
        }
        public void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                if(_transaction != null)
                {
                    _transaction.Rollback();
                    _transaction = null;
                }

                if (_connection == null || !_ownsConnection) return;
                _connection.Close();
                _connection = null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



    }
}
