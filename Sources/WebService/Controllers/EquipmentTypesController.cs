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
	public class EquipmentTypesController : BaseController
	{
		public EquipmentTypesController(WebServiceDbContext context) : base(context)
		{
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<EquipmentTypeInfo>>> GetEquipmentTypes()
		{
			var equipmentTypes = await Context.EquipmentTypes.ToListAsync();
			return equipmentTypes.Select(x => x.ToInfo()).ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<EquipmentTypeInfo>> GetEquipmentType(long id)
		{
			var equipmentType = await Context.EquipmentTypes.FindAsync(id);
			return equipmentType.ToInfo();
		}

		[HttpGet("{id}/isReferenced")]
		public async Task<ActionResult<bool>> GetIsReferenced(long id)
		{
			return await Context.TradingEquipmentModels.AnyAsync(x => x.Type.Id == id);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutEquipmentType(UpdateEquipmentTypeCommand command)
		{
			var equipmentType = command.EquipmentType.FromInfo();
			Context.Entry(equipmentType).State = EntityState.Modified;
			await Context.SaveChangesAsync();
			return NoContent();
		}

		[HttpPost]
		public async Task<ActionResult<EquipmentTypeInfo>> PostEquipmentType(AddEquipmentTypeCommand command)
		{
			var equipmentType = command.EquipmentType.FromInfo();
			Context.EquipmentTypes.Add(equipmentType);
			await Context.SaveChangesAsync();
			return CreatedAtAction(nameof(GetEquipmentType), new { id = equipmentType.Id }, equipmentType.ToInfo());
		}

		[HttpDelete("{id}")]
		public Task<IActionResult> DeleteEquipmentType(long id)
		{
			return DeleteEntity(Context.EquipmentTypes, id);
		}
	}
}