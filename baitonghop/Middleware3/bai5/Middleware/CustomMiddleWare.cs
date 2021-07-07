using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

public class CustomMiddleWare
{
    private readonly RequestDelegate _next;

    public CustomMiddleWare(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        if (context.Request.Query.Keys.Count > 0)
        {
            foreach (var key in context.Request.Query.Keys)
            {
                var data = context.Request.Query[key];
                if (!string.IsNullOrWhiteSpace(data))
                {
                    context.Request.Headers.Append(key, data);
                }
            }

        }
        foreach (var header in context.Request.Headers)
        {
            await context.Response.WriteAsync($"\n {header.Key}: {header.Value}");
        }

        await _next(context);
    }
}
public static class CustomMiddleWareExtension
{
    public static IApplicationBuilder UseCustomMiddleWare(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CustomMiddleWare>();
    }
}