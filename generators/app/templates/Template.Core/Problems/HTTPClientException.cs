using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Problems
{
   public class HTTPClientException : ProblemDetailsException
    {
 

        public HTTPClientException(string type,int StatusCode, string detail, string ErrorCode) : base(
          new ProblemDetails
          {
              Type = type,
              Detail = detail,
              Status = StatusCode,
              Extensions = { ["errorcode"] = $"{ErrorCode}" }
          })
        {
        }
    }
}
