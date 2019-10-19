using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.InfoObjects;

namespace Gui.Services
{
	public interface ITradingEquipmentModelService
	{
		Task<IEnumerable<TradingEquipmentModelInfo>> GetAllAsync();
		Task<TradingEquipmentModelInfo> GetAsync(long id);
		Task<bool> GetIsReferencedAsync(long id);
		Task<TradingEquipmentModelInfo> AddAsync(TradingEquipmentModelInfo tradingEquipmentModel);
		Task UpdateAsync(TradingEquipmentModelInfo tradingEquipmentModel);
		Task RemoveAsync(long id);
	}
}