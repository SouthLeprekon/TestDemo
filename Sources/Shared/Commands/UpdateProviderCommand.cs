using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Commands
{
	[Route("providers/{id}")]
	public class UpdateProviderCommand : IReturnVoid
	{
		public long Id { get; set; }
		public ProviderInfo Provider { get; set; }
	}
}