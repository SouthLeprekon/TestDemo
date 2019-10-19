using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Commands;
using Shared.InfoObjects;
using Shared.Queries;

namespace Gui.Services
{
	public class TradingEquipmentModelService : BaseService, ITradingEquipmentModelService
	{
		public Task<IEnumerable<TradingEquipmentModelInfo>> GetAllAsync()
		{
			return JsonServiceClient.GetAsync(new GetAllTradingEquipmentModelsQuery());
		}

		public Task<TradingEquipmentModelInfo> GetAsync(long id)
		{
			return JsonServiceClient.GetAsync(new GetTradingEquipmentModelQuery { Id = id });
		}

		public Task<bool> GetIsReferencedAsync(long id)
		{
			return JsonServiceClient.GetAsync(new GetTradingEquipmentModelIsReferencedQuery { Id = id });
		}

		public Task<TradingEquipmentModelInfo> AddAsync(TradingEquipmentModelInfo tradingEquipmentModel)
		{
			if (tradingEquipmentModel == null) throw new ArgumentNullException(nameof(tradingEquipmentModel));

			return JsonServiceClient.PostAsync(new AddTradingEquipmentModelCommand { TradingEquipmentModel = tradingEquipmentModel });
		}

		public Task UpdateAsync(TradingEquipmentModelInfo tradingEquipmentModel)
		{
			if (tradingEquipmentModel == null) throw new ArgumentNullException(nameof(tradingEquipmentModel));

			return JsonServiceClient.PutAsync(new UpdateTradingEquipmentModelCommand
			{
				Id = tradingEquipmentModel.Id,
				TradingEquipmentModel = tradingEquipmentModel
			});
		}

		public Task RemoveAsync(long id)
		{
			return JsonServiceClient.DeleteAsync(new RemoveTradingEquipmentModelCommand { Id = id });
		}
	}
}