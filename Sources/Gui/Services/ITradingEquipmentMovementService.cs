using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.InfoObjects;

namespace Gui.Services
{
	public interface ITradingEquipmentMovementService
	{
		Task<IEnumerable<TradingEquipmentMovementInfo>> GetAllAsync();
	}
}