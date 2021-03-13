using Template.Common.Attributes;
using Template.Core.Models;
using Template.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Template.Services.Services.ImplLog
{
    [Bean]
    [HostEnvironment(Common.Enums.HostEnvironment.Production)]
    class LogFileService : ILogService
    {
        
        public async Task log(Log log)
        {
          
        }
    }
}
