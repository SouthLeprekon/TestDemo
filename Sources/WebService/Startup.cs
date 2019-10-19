using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebService
{
	public class Startup
	{
		private readonly IConfiguration _configuration;

		public Startup(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<WebServiceDbContext>(x => x.UseSqlite(GetConnectionString()));
			services.AddControllers();
		}

		public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment webHostEnvironment)
		{
			if (webHostEnvironment.IsDevelopment())
				applicationBuilder.UseDeveloperExceptionPage();

			applicationBuilder.UseHttpsRedirection();
			applicationBuilder.UseRouting();
			applicationBuilder.UseAuthorization();
			applicationBuilder.UseEndpoints(x => x.MapControllers());
		}

		private string GetConnectionString()
		{
			return $"Data Source={_configuration.GetValue<string>("DataBaseName")}";
		}
	}
}