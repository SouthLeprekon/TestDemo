using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Commands;
using Shared.InfoObjects;
using WebService.Extensions;

namespace WebService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class LocationsController : BaseController
	{
		public LocationsController(WebServiceDbContext context) : base(context)
		{
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<LocationInfo>>> GetLocations()
		{
			var locations = await Context.Locations.ToListAsync();
			return locations.Select(x => x.ToInfo()).ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<LocationInfo>> GetLocation(long id)
		{
			var location = await Context.Locations.FindAsync(id);
			return location.ToInfo();
		}

		[HttpGet("{id}/isReferenced")]
		public async Task<ActionResult<bool>> GetIsReferenced(long id)
		{
			return await Context.TradingEquipment.AnyAsync(x => x.Location.Id == id)
				|| await Context.TradingEquipmentMovements.AnyAsync(x => x.Source != null && x.Source.Id == id || x.Destination.Id == id);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutLocation(UpdateLocationCommand command)
		{
			var location = command.Location.FromInfo();
			Context.Entry(location).State = EntityState.Modified;
			await Context.SaveChangesAsync();
			return NoContent();
		}

		[HttpPost]
		public async Task<ActionResult<LocationInfo>> PostLocation(AddLocationCommand command)
		{
			var location = command.Location.FromInfo();
			Context.Locations.Add(location);
			await Context.SaveChangesAsync();
			return CreatedAtAction(nameof(GetLocation), new { id = location.Id }, location.ToInfo());
		}

		[HttpDelete("{id}")]
		public Task<IActionResult> DeleteLocation(long id)
		{
			return DeleteEntity(Context.Locations, id);
		}
	}
}