using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace PassengerInfomation.Api
{
	public class IOC
	{

		public static void ConfigureServices(IServiceCollection services, IConfiguration config)
		{
			var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

			services.AddLogging();

		}

		public static void ConfigureAppConfiguration(IConfigurationBuilder config)
		{
			var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
			if (string.IsNullOrWhiteSpace(environment))
			{
				throw new Exception("ASPNETCORE_ENVIRONMENT env variable not set.");
			}

			config.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.AddJsonFile($"appsettings.{environment.ToLowerInvariant()}.json", optional: true, reloadOnChange: true)
				.AddEnvironmentVariables();

		}

	}
}
