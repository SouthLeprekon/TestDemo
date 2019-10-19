using ServiceStack;

namespace Shared.Queries
{
	[Route("tradingEquipmentModels/{id}/isReferenced")]
	public class GetTradingEquipmentModelIsReferencedQuery : IReturn<bool>
	{
		public long Id { get; set; }
	}
}