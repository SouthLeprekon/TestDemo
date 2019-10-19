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
	public class ProducersController : BaseController
	{
		public ProducersController(WebServiceDbContext context) : base(context)
		{
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<ProducerInfo>>> GetProducers()
		{
			var producers = await Context.Producers.ToListAsync();
			return producers.Select(x => x.ToInfo()).ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<ProducerInfo>> GetProducer(long id)
		{
			var producer = await Context.Producers.FindAsync(id);
			return producer.ToInfo();
		}

		[HttpGet("{id}/isReferenced")]
		public async Task<ActionResult<bool>> GetIsReferenced(long id)
		{
			return await Context.TradingEquipmentModels.AnyAsync(x => x.Producer.Id == id);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutProducer(UpdateProducerCommand command)
		{
			var producer = command.Producer.FromInfo();
			Context.Entry(producer).State = EntityState.Modified;
			await Context.SaveChangesAsync();
			return NoContent();
		}

		[HttpPost]
		public async Task<ActionResult<ProducerInfo>> PostProducer(AddProducerCommand command)
		{
			var producer = command.Producer.FromInfo();
			Context.Producers.Add(producer);
			await Context.SaveChangesAsync();
			return CreatedAtAction(nameof(GetProducer), new { id = producer.Id }, producer.ToInfo());
		}

		[HttpDelete("{id}")]
		public Task<IActionResult> DeleteProducer(long id)
		{
			return DeleteEntity(Context.Producers, id);
		}
	}
}