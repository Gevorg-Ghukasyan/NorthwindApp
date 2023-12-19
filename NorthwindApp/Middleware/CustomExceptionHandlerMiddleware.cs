using Core.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NorthwindApp.Middleware
{
    public class CustomExceptionHandlerMiddleware : IExceptionHandlerFeature , IMiddleware
    {
        private readonly ILogger<CustomExceptionHandlerMiddleware>? _logger;
        private readonly RequestDelegate _next;

        public CustomExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public CustomExceptionHandlerMiddleware(RequestDelegate next , ILogger<CustomExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public Exception Error => throw new NotImplementedException();

        public async Task InvokeAsync(HttpContext context)
        {
            try 
            {
      
                await _next(context);

            }
            catch(Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                if (next != null)
                {
                    await next(context);
                }
                else
                {
                    await _next(context);
                }
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError;
            var result = string.Empty;
            switch (exception)
            {
                case ValidationException validationException:
                    code = HttpStatusCode.BadRequest;
                    result = JsonSerializer.Serialize(validationException.Message);
                    break;

                case NotFoundException notFoundException:
                    code = HttpStatusCode.OK; // NotFound
                    break;

                case SomeOtherException someOtherException:
                    code = (HttpStatusCode)someOtherException.SomeOtherStatusCode;
                    result = JsonSerializer.Serialize(someOtherException.Message);
                    break;

                default:
                    code = HttpStatusCode.InternalServerError;
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            if(result == string.Empty)
            {
                result = JsonSerializer.Serialize(new {errpr = exception.Message}); 
            }

            return context.Response.WriteAsync(result);
        }

    }
}
