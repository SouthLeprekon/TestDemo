using ServiceStack;

namespace Shared.Commands
{
	[Route("tradingEquipmentModels/{id}")]
	public class RemoveTradingEquipmentModelCommand : IReturnVoid
	{
		public long Id { get; set; }
	}
}