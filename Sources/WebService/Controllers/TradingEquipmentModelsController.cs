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
	public class TradingEquipmentModelsController : BaseController
	{
		public TradingEquipmentModelsController(WebServiceDbContext context) : base(context)
		{
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<TradingEquipmentModelInfo>>> GetTradingEquipmentModels()
		{
			var tradingEquipmentModels = await Context.TradingEquipmentModels
				.Include(x => x.Type)
				.Include(x => x.Producer)
				.ToListAsync();

			return tradingEquipmentModels.Select(x => x.ToInfo()).ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<TradingEquipmentModelInfo>> GetTradingEquipmentModel(long id)
		{
			var tradingEquipmentModel = await Context.TradingEquipmentModels
				.Include(x => x.Type)
				.Include(x => x.Producer)
				.FirstAsync(x => x.Id == id);

			return tradingEquipmentModel.ToInfo();
		}

		[HttpGet("{id}/isReferenced")]
		public async Task<ActionResult<bool>> GetIsReferenced(long id)
		{
			return await Context.TradingEquipment.AnyAsync(x => x.Model.Id == id)
				|| await Context.TradingEquipmentMovements.AnyAsync(x => x.Model.Id == id);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutTradingEquipmentModel(UpdateTradingEquipmentModelCommand command)
		{
			var tradingEquipmentModel = await FromInfo(command.TradingEquipmentModel);
			Context.Entry(tradingEquipmentModel).State = EntityState.Modified;
			await Context.SaveChangesAsync();
			return NoContent();
		}

		[HttpPost]
		public async Task<ActionResult<TradingEquipmentModelInfo>> PostTradingEquipmentModel(AddTradingEquipmentModelCommand command)
		{
			var tradingEquipmentModel = await FromInfo(command.TradingEquipmentModel);
			Context.TradingEquipmentModels.Add(tradingEquipmentModel);

			await Context.SaveChangesAsync();
			return CreatedAtAction(nameof(GetTradingEquipmentModel), new { id = tradingEquipmentModel.Id }, tradingEquipmentModel.ToInfo());
		}

		[HttpDelete("{id}")]
		public Task<IActionResult> DeleteTradingEquipmentModel(long id)
		{
			return DeleteEntity(Context.TradingEquipmentModels, id);
		}

		private async Task<TradingEquipmentModel> FromInfo(TradingEquipmentModelInfo tradingEquipmentModel)
		{
			return new TradingEquipmentModel
			{
				Id = tradingEquipmentModel.Id,
				Name = tradingEquipmentModel.Name,
				Type = await Context.EquipmentTypes.FindAsync(tradingEquipmentModel.Type.Id),
				Producer = await Context.Producers.FindAsync(tradingEquipmentModel.Producer.Id)
			};
		}
	}
}