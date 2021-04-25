using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ToDoListMVC
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate next;

        public TokenMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Cookies["token"];

            if (string.IsNullOrWhiteSpace(token))
            {
                await context.Response.WriteAsync("Invalid token!");
            }
            else
            {
                await next.Invoke(context);
            }
        }
    }
}