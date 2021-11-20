using System;
using aal_onedrive;
using framewolf.net.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using mxwlf.net.Jaime.Abstractions;

namespace mxwlf.net.Jaime
{
    class Program
    {
        static void Main(string[] args)
        {

           var wolfHostBuilder = WolfHost.CreateDefaultHostBuilder(args);
           wolfHostBuilder.ConfigureServices(x =>
           {
               x.AddScoped<IMigration, Migration>();
           });
           
           var host = wolfHostBuilder.Build();

           var myService = host.Services.GetService<IMigration>();
           myService.Migrate(args);
            
            host.Dispose();

        }
    }
}
