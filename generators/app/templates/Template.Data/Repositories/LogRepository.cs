using Template.Core.Models;
using Template.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Data.Repositories
{
 
    public class LogRepository : Repository<Log>, ILogRepository
    { 
        public LogRepository(HostDBContext repositoryContext)
        : base(repositoryContext)
        {

        }
 
        public HostDBContext DBContext
        {
            get { return Context as HostDBContext; }
        }
    }
}
