using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Commands
{
	[Route("equipmentTypes")]
	public class AddEquipmentTypeCommand : IReturn<EquipmentTypeInfo>
	{
		public EquipmentTypeInfo EquipmentType { get; set; }
	}
}