using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("providers/{id}")]
	public class GetProviderQuery : IReturn<ProviderInfo>
	{
		public long Id { get; set; }
	}
}