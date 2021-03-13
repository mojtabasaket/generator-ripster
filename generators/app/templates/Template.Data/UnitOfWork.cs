using Template.Common.Attributes;
using Template.Core;
using Template.Core.Repositories;
using Template.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Threading.Tasks;

namespace Template.Data
{
    [Bean]
    class UnitOfWork : IUnitOfWork
    {
        private readonly HostDBContext _context;
        private IDbContextTransaction _dbContextTransaction;
        ILogRepository _logRepository;

        public ILogRepository logRepository
        {
            get
            {
                return _logRepository = _logRepository ?? new LogRepository(_context);
            }
        }
        public UnitOfWork(HostDBContext context)
        {
            _context = context;

        }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }


        public void BeginTransaction()
        {
            if (_dbContextTransaction == null)
                _dbContextTransaction = _context.Database.BeginTransaction();


        }
        public void BeginTransaction(IsolationLevel isolationLevel)
        {
            if (_dbContextTransaction == null)
                _dbContextTransaction = _context.Database.BeginTransaction(isolationLevel);
        }
        public void RollbackTransaction()
        {
            if (_dbContextTransaction != null)
                _dbContextTransaction.Rollback();

        }
        public void CommitTransaction()
        {
            if (_dbContextTransaction != null)
                _dbContextTransaction.Commit();

        }
        public void DisposeTransaction()
        {
            if (_dbContextTransaction != null)
            {
                _dbContextTransaction.Dispose();
                _dbContextTransaction = null;
            }
        }
    }
}
