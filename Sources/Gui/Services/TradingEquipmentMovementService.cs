using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.InfoObjects;
using Shared.Queries;

namespace Gui.Services
{
	public class TradingEquipmentMovementService : BaseService, ITradingEquipmentMovementService
	{
		public Task<IEnumerable<TradingEquipmentMovementInfo>> GetAllAsync()
		{
			return JsonServiceClient.GetAsync(new GetAllTradingEquipmentMovementsQuery());
		}
	}
}