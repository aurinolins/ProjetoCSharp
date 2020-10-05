using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace prog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<app02.Startup>();
    }
}
