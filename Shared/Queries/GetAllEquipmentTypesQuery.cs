using System.Collections.Generic;
using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("equipmentTypes")]
	public class GetAllEquipmentTypesQuery : IReturn<IEnumerable<EquipmentTypeInfo>>
	{
	}
}