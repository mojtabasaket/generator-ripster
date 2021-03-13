using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Models;

namespace Template.Data.Query
{
    public class GetLogByIdQuery : IRequest<Log>
    {
        public int Id { get; set; }
    }
}
