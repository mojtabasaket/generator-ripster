using Template.Core.Repositories;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Template.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ILogRepository logRepository { get; }
        int Complete();

        Task<int> CompleteAsync();
        void BeginTransaction();
        void BeginTransaction(IsolationLevel isolationLevel);
       
        void RollbackTransaction();

        void CommitTransaction();
        void DisposeTransaction();
    }
}
