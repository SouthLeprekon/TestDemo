using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Commands
{
	[Route("producers")]
	public class AddProducerCommand : IReturn<ProducerInfo>
	{
		public ProducerInfo Producer { get; set; }
	}
}