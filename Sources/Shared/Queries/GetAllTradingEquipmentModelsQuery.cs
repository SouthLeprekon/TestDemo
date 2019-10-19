using System.Collections.Generic;
using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("tradingEquipmentModels")]
	public class GetAllTradingEquipmentModelsQuery : IReturn<IEnumerable<TradingEquipmentModelInfo>>
	{
	}
}