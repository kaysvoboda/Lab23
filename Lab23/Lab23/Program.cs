using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Lab23.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Lab23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using(var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<MovieDbContext>();
                DbInitializer.Initialize(context);
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
