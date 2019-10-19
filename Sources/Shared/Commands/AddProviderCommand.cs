using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Commands
{
	[Route("providers")]
	public class AddProviderCommand : IReturn<ProviderInfo>
	{
		public ProviderInfo Provider { get; set; }
	}
}