using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Commands;
using Shared.InfoObjects;
using WebService.Extensions;

namespace WebService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TradingEquipmentController : BaseController
	{
		public TradingEquipmentController(WebServiceDbContext context) : base(context)
		{
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<TradingEquipmentInfo>>> GetAllTradingEquipment()
		{
			var tradingEquipment = await QueryTradingEquipment().ToListAsync();
			return tradingEquipment.Select(x => x.ToInfo()).ToList();
		}

		[HttpGet("{minPurchaseDate}")]
		public async Task<ActionResult<IEnumerable<TradingEquipmentInfo>>> GetTradingEquipment(DateTime minPurchaseDate)
		{
			var tradingEquipment = await QueryTradingEquipment()
				.Where(x => x.Purchased >= minPurchaseDate)
				.ToListAsync();

			return tradingEquipment.Select(x => x.ToInfo()).ToList();
		}

		[HttpPost]
		public async Task<ActionResult> RegisterTradingEquipment(RegisterTradingEquipmentCommand command)
		{
			var date = DateTime.FromBinary(command.DateBinary);
			var tradingEquipment = await FindTradingEquipmentAsync(
				command.TradingEquipmentModelId,
				command.ProviderId,
				command.LocationId,
				date);

			if (tradingEquipment != null)
			{
				tradingEquipment.Amount += command.Amount;
				Context.Entry(tradingEquipment).State = EntityState.Modified;
			}
			else
			{
				tradingEquipment = new TradingEquipment
				{
					Model = await Context.TradingEquipmentModels.FindAsync(command.TradingEquipmentModelId),
					Provider = await Context.Providers.FindAsync(command.ProviderId),
					Location = await Context.Locations.FindAsync(command.LocationId),
					Purchased = date,
					Amount = command.Amount
				};

				Context.TradingEquipment.Add(tradingEquipment);
			}

			Context.TradingEquipmentMovements.Add(new TradingEquipmentMovement
			{
				Model = await Context.TradingEquipmentModels.FindAsync(command.TradingEquipmentModelId),
				Destination = await Context.Locations.FindAsync(command.LocationId),
				Date = date,
				Amount = command.Amount
			}); ;

			await Context.SaveChangesAsync();
			return NoContent();
		}

		[HttpPost("location")]
		public async Task<ActionResult> MoveTradingEquipment(MoveTradingEquipmentCommand command)
		{
			var source = await QueryTradingEquipment().Where(x => x.Id == command.TradingEquipmentId).FirstAsync();

			Context.TradingEquipmentMovements.Add(new TradingEquipmentMovement
			{
				Model = source.Model,
				Source = source.Location,
				Destination = await Context.Locations.FindAsync(command.LocationId),
				Date = DateTime.Now,
				Amount = command.Amount
			});

			DecreaseSourceAmount(source, command.Amount);
			await IncreaseDestinationAmountAsync(source, command.LocationId, command.Amount);
			await Context.SaveChangesAsync();
			return NoContent();
		}

		private IQueryable<TradingEquipment> QueryTradingEquipment()
		{
			return Context.TradingEquipment
				.Include(x => x.Model)
				.Include(x => x.Model.Type)
				.Include(x => x.Model.Producer)
				.Include(x => x.Provider)
				.Include(x => x.Location);
		}

		private void DecreaseSourceAmount(TradingEquipment source, int amountToSubtract)
		{
			if (source.Amount == amountToSubtract)
			{
				Context.TradingEquipment.Remove(source);
			}
			else
			{
				source.Amount -= amountToSubtract;
				Context.Entry(source).State = EntityState.Modified;
			}
		}

		private async Task IncreaseDestinationAmountAsync(TradingEquipment source, long newLocationId, int amountToAdd)
		{
			var destination = await FindTradingEquipmentAsync(
				source.Model.Id,
				source.Provider.Id,
				newLocationId,
				source.Purchased);

			if (destination != null)
			{
				destination.Amount += amountToAdd;
				Context.Entry(destination).State = EntityState.Modified;
				return;
			}

			destination = new TradingEquipment
			{
				Model = source.Model,
				Provider = source.Provider,
				Location = await Context.Locations.FindAsync(newLocationId),
				Purchased = source.Purchased,
				Amount = amountToAdd
			};

			Context.TradingEquipment.Add(destination);
		}

		private Task<TradingEquipment> FindTradingEquipmentAsync(long typeId, long providerId, long locationId, DateTime purchased)
		{
			return QueryTradingEquipment()
				.Where(x =>
					x.Model.Id == typeId &&
					x.Provider.Id == providerId &&
					x.Location.Id == locationId &&
					x.Purchased == purchased)
				.FirstOrDefaultAsync();
		}
	}
}