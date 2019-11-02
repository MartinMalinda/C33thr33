using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Models
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        private Printer printer { get; set; }
        private IColor color;
        public ConsoleLoggerMiddleware(IColor color)
        {
            this.color = color;
        }

        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            color.PrintColor();

            return next(context);
        }
    }
}
