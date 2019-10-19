using ServiceStack;

namespace Shared.Commands
{
	[Route("locations/{id}")]
	public class RemoveLocationCommand : IReturnVoid
	{
		public long Id { get; set; }
	}
}