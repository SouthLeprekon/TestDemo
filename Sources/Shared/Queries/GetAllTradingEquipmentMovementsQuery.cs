using System.Collections.Generic;
using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("tradingEquipmentMovements")]
	public class GetAllTradingEquipmentMovementsQuery : IReturn<IEnumerable<TradingEquipmentMovementInfo>>
	{
	}
}