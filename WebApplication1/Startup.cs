using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseEndpoints(options => 
            {
                options.MapControllerRoute("default", "{controller}/ {action}/ {id?}");
            });
            app.UseRouting();
            app.Run(async context => 
            {
                await context.Response.WriteAsync("Hello World!");
            });

            app.Use(async (context,next) =>
            {
                await context.Response.WriteAsync("Hello World!");
                await next.Invoke();
            })
        }
    }
}
