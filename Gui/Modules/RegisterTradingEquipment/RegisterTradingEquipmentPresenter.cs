using System;
using Gui.Services;

namespace Gui.Modules.RegisterTradingEquipment
{
	public class RegisterTradingEquipmentPresenter : IRegisterTradingEquipmentPresenter
	{
		private readonly IRegisterTradingEquipmentView _view;
		private readonly ITradingEquipmentService _tradingEquipmentService;
		private readonly ITradingEquipmentModelService _tradingEquipmentModelService;
		private readonly IProviderService _providerService;
		private readonly ILocationService _locationService;

		public RegisterTradingEquipmentPresenter(
			IRegisterTradingEquipmentView view,
			ITradingEquipmentService tradingEquipmentService,
			ITradingEquipmentModelService tradingEquipmentModelService,
			IProviderService providerService,
			ILocationService locationService)
		{
			if (view == null) throw new ArgumentNullException(nameof(view));
			if (tradingEquipmentService == null) throw new ArgumentNullException(nameof(tradingEquipmentService));
			if (tradingEquipmentModelService == null) throw new ArgumentNullException(nameof(tradingEquipmentModelService));
			if (providerService == null) throw new ArgumentNullException(nameof(providerService));
			if (locationService == null) throw new ArgumentNullException(nameof(locationService));

			_view = view;
			_view.Observer = this;
			_tradingEquipmentService = tradingEquipmentService;
			_tradingEquipmentModelService = tradingEquipmentModelService;
			_providerService = providerService;
			_locationService = locationService;
		}

		public async void OpenView()
		{
			_view.TradingEquipmentModels = await _tradingEquipmentModelService.GetAllAsync();
			_view.Providers = await _providerService.GetAllAsync();
			_view.Locations = await _locationService.GetAllAsync();
			_view.Open();
		}

		public async void RegisterTradingEquipmentRequested()
		{
			await _tradingEquipmentService.RegisterAsync(
				_view.SelectedTradingEquipmentModel.Id,
				_view.SelectedProvider.Id,
				_view.SelectedLocation.Id,
				_view.Date,
				_view.Amount);
		}
	}
}