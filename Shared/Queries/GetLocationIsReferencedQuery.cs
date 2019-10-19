using ServiceStack;

namespace Shared.Queries
{
	[Route("locations/{id}/isReferenced")]
	public class GetLocationIsReferencedQuery : IReturn<bool>
	{
		public long Id { get; set; }
	}
}