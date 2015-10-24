using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace AspNet5Primer.WebApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Map("/echo", config => config.Run(async context =>
            {
                var path = context.Request.Path.ToString();
                await context.Response.WriteAsync(path);
            }));

            app.Map("/upper", config => config.Run(async context =>
            {
                var path = context.Request.Path.ToString().ToUpper();
                await context.Response.WriteAsync(path);
            }));
        }
    }
}
