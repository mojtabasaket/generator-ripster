using Template.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Template.Core.Services
{
    public interface ILogService
    {
        Task log(Log log);
    }
}
