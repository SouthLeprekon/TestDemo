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
	public class ProvidersController : BaseController
	{
		public ProvidersController(WebServiceDbContext context) : base(context)
		{
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<ProviderInfo>>> GetProviders()
		{
			var providers = await Context.Providers.ToListAsync();
			return providers.Select(x => x.ToInfo()).ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<ProviderInfo>> GetProvider(long id)
		{
			var provider = await Context.Providers.FindAsync(id);
			return provider.ToInfo();
		}

		[HttpGet("{id}/isReferenced")]
		public async Task<ActionResult<bool>> GetIsReferenced(long id)
		{
			return await Context.TradingEquipment.AnyAsync(x => x.Provider.Id == id);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutProvider(UpdateProviderCommand command)
		{
			var provider = command.Provider.FromInfo();
			Context.Entry(provider).State = EntityState.Modified;
			await Context.SaveChangesAsync();
			return NoContent();
		}

		[HttpPost]
		public async Task<ActionResult<ProviderInfo>> PostProvider(AddProviderCommand command)
		{
			var provider = command.Provider.FromInfo();
			Context.Providers.Add(provider);
			await Context.SaveChangesAsync();
			return CreatedAtAction(nameof(GetProvider), new { id = provider.Id }, provider.ToInfo());
		}

		[HttpDelete("{id}")]
		public Task<IActionResult> DeleteProvider(long id)
		{
			return DeleteEntity(Context.Providers, id);
		}
	}
}