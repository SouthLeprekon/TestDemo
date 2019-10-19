using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Commands
{
	[Route("locations/{id}")]
	public class UpdateLocationCommand : IReturnVoid
	{
		public long Id { get; set; }
		public LocationInfo Location { get; set; }
	}
}