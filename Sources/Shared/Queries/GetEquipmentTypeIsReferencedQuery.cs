using ServiceStack;

namespace Shared.Queries
{
	[Route("equipmentTypes/{id}/isReferenced")]
	public class GetEquipmentTypeIsReferencedQuery : IReturn<bool>
	{
		public long Id { get; set; }
	}
}