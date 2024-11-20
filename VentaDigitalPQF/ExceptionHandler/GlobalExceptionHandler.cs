using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.VentaDigitalPQF.ExceptionHandler;


namespace VentaDigitalPQF.ExceptionHandler;

public class GlobalExceptionHandler : IExceptionHandler
{
    

    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,Exception exception, CancellationToken cancellationToken)
    {
        httpContext.Response.ContentType = "application/json";

        var contextFeature = httpContext.Features.Get<IExceptionHandlerFeature>();
        if (contextFeature is not null)
        {
            httpContext.Response.StatusCode = contextFeature.Error switch
            {
                UnauthorizedException => StatusCodes.Status401Unauthorized,
                AppException => StatusCodes.Status400BadRequest,
                NotFoundException => StatusCodes.Status404NotFound,
                _ => StatusCodes.Status500InternalServerError
            };

            await httpContext.Response.WriteAsJsonAsync(new ProblemDetails
            {
                Status = httpContext.Response.StatusCode,
                Detail = contextFeature.Error.Message,
                Title = "Error occured"
            });
        }

        return true;
    }
}