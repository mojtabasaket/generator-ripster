using System;
using System.Diagnostics;
using System.Security.Authentication;
using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Template.Core.Problems {
    public class ProblemDetailsConfiguration : IConfigureOptions<ProblemDetailsOptions> {
        [Obsolete]
        public ProblemDetailsConfiguration(IHostingEnvironment environment, IHttpContextAccessor httpContextAccessor)
        {
            _environment = environment;
            _HttpContextAccessor = httpContextAccessor;
        }

        [Obsolete]
        private IHostingEnvironment _environment { get; }
        private IHttpContextAccessor _HttpContextAccessor { get; }

        [Obsolete]
        public void Configure(ProblemDetailsOptions options)
        {
            options.IncludeExceptionDetails = ctx => _environment.IsDevelopment();

            options.OnBeforeWriteDetails = (details,http) =>
            {
                // keep consistent with asp.net core 2.2 conventions that adds a tracing value
                var traceId = Activity.Current?.Id ?? _HttpContextAccessor.HttpContext.TraceIdentifier;
                http.Extensions["traceId"] = traceId;
            };

            options.Map<AuthenticationException>(exception =>
                new ExceptionProblemDetails(exception, StatusCodes.Status401Unauthorized));
            options.Map<NotImplementedException>(exception =>
                new ExceptionProblemDetails(exception, StatusCodes.Status501NotImplemented));

            //TODO add Headers to HTTP responses
        }
    }
}
