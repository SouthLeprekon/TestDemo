using System.Collections.Generic;
using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("tradingEquipment")]
	public class GetAllTradingEquipmentQuery : IReturn<IEnumerable<TradingEquipmentInfo>>
	{
	}
}