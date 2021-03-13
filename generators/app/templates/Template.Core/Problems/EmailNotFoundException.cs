using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Template.Core.Problems {
    public class EmailNotFoundException : ProblemDetailsException {
        public EmailNotFoundException() : base(new ProblemDetails {
            Type = ErrorConstants.EmailNotFoundType,
            Detail = "Email address not registered",
            Status = StatusCodes.Status400BadRequest
        })
        {
        }
    }
}