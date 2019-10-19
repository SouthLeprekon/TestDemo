using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.InfoObjects;
using WebService.Extensions;

namespace WebService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TradingEquipmentMovementsController : BaseController
	{
		public TradingEquipmentMovementsController(WebServiceDbContext context) : base(context)
		{
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<TradingEquipmentMovementInfo>>> GetAllTradingEquipmentMovements()
		{
			var tradingEquipmentMovements = await QueryTradingEquipmentMovements().ToListAsync();
			return tradingEquipmentMovements.Select(x => x.ToInfo()).ToList();
		}

		private IQueryable<TradingEquipmentMovement> QueryTradingEquipmentMovements()
		{
			return Context.TradingEquipmentMovements
				.Include(x => x.Model)
				.Include(x => x.Model.Type)
				.Include(x => x.Model.Producer)
				.Include(x => x.Source)
				.Include(x => x.Destination);
		}
	}
}