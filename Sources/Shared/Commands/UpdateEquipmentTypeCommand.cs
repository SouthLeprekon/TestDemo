using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Commands
{
	[Route("equipmentTypes/{id}")]
	public class UpdateEquipmentTypeCommand : IReturnVoid
	{
		public long Id { get; set; }
		public EquipmentTypeInfo EquipmentType { get; set; }
	}
}