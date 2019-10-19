using ServiceStack;

namespace Shared.Queries
{
	[Route("producers/{id}/isReferenced")]
	public class GetProducerIsReferencedQuery : IReturn<bool>
	{
		public long Id { get; set; }
	}
}