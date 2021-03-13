using System;
using System.Collections.Generic;
using System.Data;

namespace Template.Core.Data
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
    }
}
