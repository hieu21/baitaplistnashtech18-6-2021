using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

public class CustomMiddleWare{
    private readonly RequestDelegate _next;

    public CustomMiddleWare(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext httpContext){
        await httpContext.Response.WriteAsync("<div> Hello from Simple Middleware </div>");
        await httpContext.Response.WriteAsync(string.Format("{0}://{1}, {2} ,{3} {4}", httpContext.Request.Scheme, httpContext.Request.Host, httpContext.Request.Path, httpContext.Request.QueryString, httpContext.Request.Body));
        string[] lines =
        {
            $"{httpContext.Request.Scheme}", 
            $"{httpContext.Request.Host}", 
            $"{httpContext.Request.Path}",  
            $"{httpContext.Request.QueryString}", 
            $"{httpContext.Request.Body}"
        };

        await File.WriteAllLinesAsync("WriteLines.txt", lines);
        await _next(httpContext);
    }
}
public static class CustomMiddleWareExtension{
    public static IApplicationBuilder UseCustomMiddleWare(this IApplicationBuilder builder){
        return builder.UseMiddleware<CustomMiddleWare>();
    }
}