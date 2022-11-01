using System.Net;
using Rh.Domain.DTOs;
using Rh.Domain.Exceptions;

namespace Rh.Api.Config;

public class ErroMiddleware
{
    private readonly RequestDelegate _next;

    public ErroMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await TratamentoExcecao(context, ex);
        }
    }

    private Task TratamentoExcecao(HttpContext context, Exception ex)
    {
        HttpStatusCode status;
        string message;
        if(ex is NaoAutorizadoException)
        {
            status = HttpStatusCode.Unauthorized;
            message = ex.Message;
        }
        else if(ex is NaoAutorizadoException)
        {
            status = HttpStatusCode.Forbidden;
            message = ex.Message;
        }
        else
        {
            status = HttpStatusCode.InternalServerError;
            message = "Ocorreu um erro, favor contactar a TI!";
        }

        var response = new ErrorDTO(message);

        context.Response.StatusCode = (int)status;

        return context.Response.WriteAsJsonAsync(response);
    }
}
