using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using MadLibs.Models;



namespace MadLibs.Models
{
    public class Program
    {

       public static void Main(string[] args)
        {
            // ASP.net pipeline
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            // for the https certificate we installed
            app.UseHttpsRedirection();

            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }



    }
}