using ServiceStack;

namespace Shared.Commands
{
	[Route("producers/{id}")]
	public class RemoveProducerCommand : IReturnVoid
	{
		public long Id { get; set; }
	}
}