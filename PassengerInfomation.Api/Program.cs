using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace PassengerInfomation.Api
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureAppConfiguration((hostingContext, config) => IOC.ConfigureAppConfiguration(config))
				.ConfigureServices((context, services) => IOC.ConfigureServices(services, context.Configuration))
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
