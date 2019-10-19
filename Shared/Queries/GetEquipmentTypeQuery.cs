using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("equipmentTypes/{id}")]
	public class GetEquipmentTypeQuery : IReturn<EquipmentTypeInfo>
	{
		public long Id { get; set; }
	}
}