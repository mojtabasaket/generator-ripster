using Dapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Template.Common.Attributes;
using Template.Core.Data;
using Template.Core.Models;
using Template.Data;

namespace Template.Data.Query
{

    //[Bean]
    public class GetLogByIdQueryHandler : IRequestHandler<GetLogByIdQuery, Log>
    {
        private readonly HostDBContext _dBContext;

        private readonly ISqlConnectionFactory _sqlConnectionFactory;
        public GetLogByIdQueryHandler(HostDBContext dBContext, ISqlConnectionFactory sqlConnectionFactory)
        {
            _dBContext = dBContext;
            _sqlConnectionFactory = sqlConnectionFactory;
        }



        public async Task<Log> Handle(GetLogByIdQuery request, CancellationToken cancellationToken)
        {

            const string sql = "SELECT * " +
                      "FROM  Losg"
                      ;

            var connection = _sqlConnectionFactory.GetOpenConnection();

            var tt = await connection.QueryAsync<List<Log>>(sql);
            return null;
            return await _dBContext.Logs.FirstOrDefaultAsync(c => c.Id == request.Id);
        }
    }
}
