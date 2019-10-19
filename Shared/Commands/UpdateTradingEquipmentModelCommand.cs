using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Commands
{
	[Route("tradingEquipmentModels/{id}")]
	public class UpdateTradingEquipmentModelCommand : IReturnVoid
	{
		public long Id { get; set; }
		public TradingEquipmentModelInfo TradingEquipmentModel { get; set; }
	}
}