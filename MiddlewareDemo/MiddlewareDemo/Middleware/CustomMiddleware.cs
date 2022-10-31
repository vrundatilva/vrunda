using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDemo.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            //if (context.Request.Method == HttpMethods.Get && context.Request.Query["name"] == "Vrunda")
            //{
            //    await context.Response.WriteAsync("Message from Class based Middleware \n");
            //}
          //  await _next(context);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class CustomMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<CustomMiddleware>();
    //    }
    //}
}
