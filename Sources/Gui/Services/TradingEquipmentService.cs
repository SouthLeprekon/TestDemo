using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Commands;
using Shared.InfoObjects;
using Shared.Queries;

namespace Gui.Services
{
	public class TradingEquipmentService : BaseService, ITradingEquipmentService
	{
		public Task<IEnumerable<TradingEquipmentInfo>> GetAllAsync()
		{
			return JsonServiceClient.GetAsync(new GetAllTradingEquipmentQuery());
		}

		public Task<IEnumerable<TradingEquipmentInfo>> GetAsync(DateTime minPurchaseDate)
		{
			return JsonServiceClient.GetAsync(new GetTradingEquipmentQuery { MinPurchaseDate = minPurchaseDate });
		}

		public Task RegisterAsync(long tradingEquipmentModelId, long providerId, long locationId, DateTime date, int amount)
		{
			return JsonServiceClient.PostAsync(new RegisterTradingEquipmentCommand
			{
				TradingEquipmentModelId = tradingEquipmentModelId,
				ProviderId = providerId,
				LocationId = locationId,
				DateBinary = date.ToBinary(),
				Amount = amount
			});
		}

		public Task MoveAsync(long tradingEquipmentId, long locationId, int amount)
		{
			return JsonServiceClient.PostAsync(new MoveTradingEquipmentCommand
			{
				TradingEquipmentId = tradingEquipmentId,
				LocationId = locationId,
				Amount = amount
			});
		}
	}
}