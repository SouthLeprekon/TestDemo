using System.Collections.Generic;
using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("locations")]
	public class GetAllLocationsQuery : IReturn<IEnumerable<LocationInfo>>
	{
	}
}