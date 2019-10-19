using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Commands
{
	[Route("tradingEquipmentModels")]
	public class AddTradingEquipmentModelCommand : IReturn<TradingEquipmentModelInfo>
	{
		public TradingEquipmentModelInfo TradingEquipmentModel { get; set; }
	}
}