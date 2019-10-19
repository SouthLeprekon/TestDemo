using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Commands
{
	[Route("locations")]
	public class AddLocationCommand : IReturn<LocationInfo>
	{
		public LocationInfo Location { get; set; }
	}
}