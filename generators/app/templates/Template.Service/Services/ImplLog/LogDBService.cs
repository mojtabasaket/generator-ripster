using Template.Common.Attributes;
using Template.Core;
using Template.Core.Models;
using Template.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Template.Data.Query;

namespace Template.Services.Services.ImplLog
{
    [Bean]
    [HostEnvironment(Common.Enums.HostEnvironment.Development)]
    public class LogDBService : ILogService
    {
        private readonly IUnitOfWork _uow;
 
        public LogDBService(IUnitOfWork uow)
        {
 
            _uow = uow;
        }
        public async Task log(Log log)
        {

 
            await _uow.logRepository.AddAsync(log);
          await  _uow.CompleteAsync();
        }
    }
}
