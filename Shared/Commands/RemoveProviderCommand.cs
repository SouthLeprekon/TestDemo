using ServiceStack;

namespace Shared.Commands
{
	[Route("providers/{id}")]
	public class RemoveProviderCommand : IReturnVoid
	{
		public long Id { get; set; }
	}
}