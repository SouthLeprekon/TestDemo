using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.InfoObjects;

namespace Gui.Services
{
	public interface ITradingEquipmentService
	{
		Task<IEnumerable<TradingEquipmentInfo>> GetAllAsync();
		Task<IEnumerable<TradingEquipmentInfo>> GetAsync(DateTime minPurchaseDate);
		Task RegisterAsync(long tradingEquipmentModelId, long providerId, long locationId, DateTime date, int amount);
		Task MoveAsync(long tradingEquipmentId, long locationId, int amount);
	}
}