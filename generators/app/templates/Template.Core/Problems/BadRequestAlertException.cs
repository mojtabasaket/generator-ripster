using Hellang.Middleware.ProblemDetails;
using Template.Core.Resource;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Template.Core.Problems
{
    public class BadRequestAlertException : ProblemDetailsException
    {

        //public BadRequestAlertException(string detail, string entityName, string errorKey) : this(
        //    ErrorConstants.DefaultType, detail, entityName, errorKey)
        //{
        //}

        //public BadRequestAlertException(string type, string detail, string entityName, string errorKey) : base(
        //    new ProblemDetails
        //    {
        //        Type = type,
        //        Detail = detail,
        //        Status = StatusCodes.Status400BadRequest,
        //        Extensions = { ["params"] = entityName, ["message"] = $"error.{errorKey}" }
        //    })
        //{
        //}

        public BadRequestAlertException(string type, string detail, string entityName, Enums.Enums.ErroreCode ErrorCode) : base(
          new ProblemDetails
          {
              Type = type,
              Detail = ResourceHelper._localizer[ErrorCode.ToString()],//MessageResource.GetMessageByErroreCode(ErrorCode),
              Status = StatusCodes.Status400BadRequest,
              Extensions = { ["params"] = entityName, ["message"] = $"error.{entityName}.{ErrorCode}", ["errorcode"] = $"{ErrorCode}" }
          })
        {
        }

        public BadRequestAlertException(string type, string detail, string entityName, Enums.Enums.ErroreCode ErrorCode, Dictionary<string, string> param) : base(
          new ProblemDetails
          {
              Type = type,
              Detail =  ResourceHelper._localizer[ErrorCode.ToString()],//MessageResource.GetMessageByErroreCode(ErrorCode),
              Status = StatusCodes.Status400BadRequest,
              Extensions = { ["params"] = param, ["message"] = $"error.{entityName}.{ErrorCode}", ["errorcode"] = $"{ErrorCode}" }
          })
        {
        }
    }
}
