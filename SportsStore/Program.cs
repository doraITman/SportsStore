using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore;

namespace SportsStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuidWebHost(args).Run();
        }

        public static IWebHost BuidWebHost (string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseDefaultServiceProvider(options => options.ValidateScopes = false)
            
            .Build();
            
    }
}
