using System.Collections.Generic;
using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("providers")]
	public class GetAllProvidersQuery : IReturn<IEnumerable<ProviderInfo>>
	{
	}
}