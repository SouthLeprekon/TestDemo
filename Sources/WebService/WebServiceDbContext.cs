using Domain;
using Microsoft.EntityFrameworkCore;

namespace WebService
{
	public class WebServiceDbContext : DbContext
	{
		public WebServiceDbContext(DbContextOptions<WebServiceDbContext> options) : base(options)
		{
		}

		public DbSet<Producer> Producers { get; set; }
		public DbSet<Provider> Providers { get; set; }
		public DbSet<EquipmentType> EquipmentTypes { get; set; }
		public DbSet<TradingEquipmentModel> TradingEquipmentModels { get; set; }
		public DbSet<TradingEquipment> TradingEquipment { get; set; }
		public DbSet<TradingEquipmentMovement> TradingEquipmentMovements { get; set; }
		public DbSet<Location> Locations { get; set; }
	}
}