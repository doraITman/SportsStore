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
            var derictory = new DirectoryInfo(@"D:\Programming\SportsStore");
            if (!derictory.Exists)
            {

            }
            else
            {
                Console.WriteLine(derictory.FullName);
                Console.WriteLine(derictory.Name);
                Console.WriteLine(derictory.Parent);
                Console.WriteLine(derictory.CreationTime);
                Console.WriteLine(derictory.LastAccessTime);

            }
            CreateHostBuilder(args).Build().Run();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>()
            .UseDefaultServiceProvider(options =>
            options.ValidateScopes = false);
        
        });


    }
}
