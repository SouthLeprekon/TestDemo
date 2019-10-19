using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("producers/{id}")]
	public class GetProducerQuery : IReturn<ProducerInfo>
	{
		public long Id { get; set; }
	}
}