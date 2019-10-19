using System.Collections.Generic;
using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("producers")]
	public class GetAllProducersQuery : IReturn<IEnumerable<ProducerInfo>>
	{
	}
}