﻿
using KuzemBackendDotnet.Application.Exceptions;
using System.Net;
using System.Text.Json;

namespace KuzemBackendDotnet.API.Extensions
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (NotFoundException ex)
            {
                await HandleNotFoundExceptionAsync(context, ex);
            }
            catch (ConflictException ex)
            {
                await ConflictExceptionAsync(context, ex);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Excepton =>", ex.InnerException);
                // Diğer türdeki istisnalar için genel hata mesajı döndürebilirsiniz
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await context.Response.WriteAsync(ex.Message);
            }
        }




        private async Task HandleNotFoundExceptionAsync(HttpContext context, NotFoundException ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = ex.StatusCode;

            var response = new
            {
                StatusCode = ex.StatusCode,
                Message = ex.Message
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        private async Task ConflictExceptionAsync(HttpContext context, ConflictException ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = ex.StatusCode;

            var response = new
            {
                StatusCode = ex.StatusCode,
                Message = ex.Message
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
