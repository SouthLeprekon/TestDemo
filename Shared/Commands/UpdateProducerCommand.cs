using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Commands
{
	[Route("producers/{id}")]
	public class UpdateProducerCommand : IReturnVoid
	{
		public long Id { get; set; }
		public ProducerInfo Producer { get; set; }
	}
}