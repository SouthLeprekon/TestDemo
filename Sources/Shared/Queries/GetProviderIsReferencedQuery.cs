using ServiceStack;

namespace Shared.Queries
{
	[Route("providers/{id}/isReferenced")]
	public class GetProviderIsReferencedQuery : IReturn<bool>
	{
		public long Id { get; set; }
	}
}