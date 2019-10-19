using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("locations/{id}")]
	public class GetLocationQuery : IReturn<LocationInfo>
	{
		public long Id { get; set; }
	}
}