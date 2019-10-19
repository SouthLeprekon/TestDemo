using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.InfoObjects;

namespace Gui.Services
{
	public interface IEquipmentTypeService
	{
		Task<IEnumerable<EquipmentTypeInfo>> GetAllAsync();
		Task<EquipmentTypeInfo> GetAsync(long id);
		Task<bool> GetIsReferencedAsync(long id);
		Task<EquipmentTypeInfo> AddAsync(EquipmentTypeInfo equipmentType);
		Task UpdateAsync(EquipmentTypeInfo equipmentType);
		Task RemoveAsync(long id);
	}
}