using ServiceStack;

namespace Shared.Commands
{
	[Route("tradingEquipment/location")]
	public class MoveTradingEquipmentCommand : IReturnVoid
	{
		public long TradingEquipmentId { get; set; }
		public long LocationId { get; set; }
		public int Amount { get; set; }
	}
}