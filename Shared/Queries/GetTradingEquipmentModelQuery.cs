using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("tradingEquipmentModels/{id}")]
	public class GetTradingEquipmentModelQuery : IReturn<TradingEquipmentModelInfo>
	{
		public long Id { get; set; }
	}
}