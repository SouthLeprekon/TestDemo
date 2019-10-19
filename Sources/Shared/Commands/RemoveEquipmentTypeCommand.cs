using ServiceStack;

namespace Shared.Commands
{
	[Route("equipmentTypes/{id}")]
	public class RemoveEquipmentTypeCommand : IReturnVoid
	{
		public long Id { get; set; }
	}
}