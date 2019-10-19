using ServiceStack;

namespace Shared.Commands
{
	[Route("tradingEquipment")]
	public class RegisterTradingEquipmentCommand : IReturnVoid
	{
		public long TradingEquipmentModelId { get; set; }
		public long ProviderId { get; set; }
		public long LocationId { get; set; }
		public long DateBinary { get; set; }
		public int Amount { get; set; }
	}
}