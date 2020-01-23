using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeCycleDependency.Services;
namespace LifeCycleDependency.Middleware
{
    public class CounterMiddleware
    {
        private RequestDelegate _next;
        int i = 0;
        public CounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context, ICounter counter, CounterService counterService)
        {
            i++;
            context.Response.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync($"Запрос {i}: ICounter = {counter.Value}; CounterService = {counterService.Counter.Value}");
        }

    }
}
