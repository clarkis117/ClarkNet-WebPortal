using ClarkNetWebPortal.DbContexts;
using ClarkNetWebPortal.Models;
using GenericMvc.Controllers;
using GenericMvc.StartupUtils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Formatting.Json;

namespace ClarkNetWebPortal
{
	public class Startup
	{
		/// <summary>
		/// Should handle getting appsettings
		///	And configure logging
		/// </summary>
		/// <param name="env"></param>
		/// <param name="loggerFactory"></param>
		public Startup(IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			Configuration = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
				.AddEnvironmentVariables()
				.Build();

			Log.Logger = new LoggerConfiguration()
				.MinimumLevel.Verbose()
				.WriteTo.RollingFile(new JsonFormatter(), "log-{Date}.json")
				.CreateLogger();

			loggerFactory.AddSerilog();
		}

		public IConfigurationRoot Configuration { get; }

		/// <summary>
		/// this is allowed to branch
		/// </summary>
		/// <param name="services"></param>
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();

			SqliteDbContext.ConnectionString = "Filename=./DataBase.db";
			services.AddEntityFrameworkSqlite();

			//Add embedded file handlers
			EmbededFilesHelper.ConfigureEmbededFileProviders(services, EmbededFilesHelper.GetGenericMvcUtils());
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="app"></param>
		/// <param name="env"></param>
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			BasicModelsController.Initialize(typeof(Host));

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseBrowserLink();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Aurelia}/");
			});
		}
	}
}