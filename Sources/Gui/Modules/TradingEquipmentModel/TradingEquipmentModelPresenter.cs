using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Gui.Extensions;
using Gui.Services;
using Shared.InfoObjects;

namespace Gui.Modules.TradingEquipmentModel
{
	public class TradingEquipmentModelPresenter : ITradingEquipmentModelPresenter
	{
		private readonly ITradingEquipmentModelView _view;
		private readonly ITradingEquipmentModelService _tradingEquipmentModelService;
		private readonly IEquipmentTypeService _equipmentTypeService;
		private readonly IProducerService _producerService;

		public TradingEquipmentModelPresenter(
			ITradingEquipmentModelView view,
			ITradingEquipmentModelService tradingEquipmentModelService,
			IEquipmentTypeService equipmentTypeService,
			IProducerService producerService)
		{
			if (view == null) throw new ArgumentNullException(nameof(view));
			if (tradingEquipmentModelService == null) throw new ArgumentNullException(nameof(tradingEquipmentModelService));
			if (equipmentTypeService == null) throw new ArgumentNullException(nameof(equipmentTypeService));
			if (producerService == null) throw new ArgumentNullException(nameof(producerService));

			_view = view;
			_view.Observer = this;
			_tradingEquipmentModelService = tradingEquipmentModelService;
			_equipmentTypeService = equipmentTypeService;
			_producerService = producerService;
		}

		public async void OpenView()
		{
			var tradingEquipmentModels = await _tradingEquipmentModelService.GetAllAsync();
			_view.TradingEquipmentModels = new BindingList<TradingEquipmentModelDisplayInfo>(tradingEquipmentModels.Select(x => new TradingEquipmentModelDisplayInfo(x)).ToList());
			EnableOperations();
			_view.Open();
		}

		public void SelectedTradingEquipmentModelChanged()
		{
			EnableOperations();
		}

		public void AddTradingEquipmentModelRequested()
		{
			RequestTradingEquipmentModelProperties(new TradingEquipmentModelInfo());
		}

		public void EditTradingEquipmentModelRequested()
		{
			RequestTradingEquipmentModelProperties(_view.SelectedTradingEquipmentModel.TradingEquipmentModel);
		}

		public async void RemoveTradingEquipmentModelRequested()
		{
			if (!_view.RemoveTradingEquipmentModelConfirmed) return;

			var tradingEquipmentModel = _view.SelectedTradingEquipmentModel;

			if (await _tradingEquipmentModelService.GetIsReferencedAsync(tradingEquipmentModel.Id))
			{
				_view.ShowTradingEquipmentModelIsReferencedWarning();
				return;
			}

			await _tradingEquipmentModelService.RemoveAsync(tradingEquipmentModel.Id);
			_view.TradingEquipmentModels.Remove(tradingEquipmentModel);
		}

		public async void TradingEquipmentModelPropertiesAccepted(TradingEquipmentModelInfo tradingEquipmentModel)
		{
			if (tradingEquipmentModel == null) throw new ArgumentNullException(nameof(tradingEquipmentModel));

			_view.SelectedTradingEquipmentModel = await SaveTradingEquipmentModelAsync(tradingEquipmentModel);
		}

		private void EnableOperations()
		{
			var tradingEquipmentModelSelected = _view.SelectedTradingEquipmentModel != null;
			_view.CanEditTradingEquipmentModel = tradingEquipmentModelSelected;
			_view.CanRemoveTradingEquipmentModel = tradingEquipmentModelSelected;
		}

		private async void RequestTradingEquipmentModelProperties(TradingEquipmentModelInfo tradingEquipmentModel)
		{
			_view.EquipmentTypes = await _equipmentTypeService.GetAllAsync();
			_view.Producers = await _producerService.GetAllAsync();
			_view.RequestTradingEquipmentModelProperties(tradingEquipmentModel);
		}

		private async Task<TradingEquipmentModelDisplayInfo> SaveTradingEquipmentModelAsync(TradingEquipmentModelInfo tradingEquipmentModel)
		{
			TradingEquipmentModelDisplayInfo displayInfo;

			if (_view.TradingEquipmentModels.All(x => x.Id != tradingEquipmentModel.Id))
			{
				tradingEquipmentModel = await _tradingEquipmentModelService.AddAsync(tradingEquipmentModel);
				displayInfo = new TradingEquipmentModelDisplayInfo(tradingEquipmentModel);
				_view.TradingEquipmentModels.Add(displayInfo);
			}
			else
			{
				await _tradingEquipmentModelService.UpdateAsync(tradingEquipmentModel);
				tradingEquipmentModel = await _tradingEquipmentModelService.GetAsync(tradingEquipmentModel.Id);
				displayInfo = new TradingEquipmentModelDisplayInfo(tradingEquipmentModel);
				_view.TradingEquipmentModels.AddOrReplace(x => x.Id == tradingEquipmentModel.Id, displayInfo);
			}

			return displayInfo;
		}
	}
}