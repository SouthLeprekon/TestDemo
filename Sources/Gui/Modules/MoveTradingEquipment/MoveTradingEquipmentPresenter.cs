using System;
using Gui.Services;

namespace Gui.Modules.MoveTradingEquipment
{
	public class MoveTradingEquipmentPresenter : IMoveTradingEquipmentPresenter
	{
		private readonly IMoveTradingEquipmentView _view;
		private readonly ITradingEquipmentService _tradingEquipmentService;
		private readonly ILocationService _locationService;

		public MoveTradingEquipmentPresenter(
			IMoveTradingEquipmentView view,
			ITradingEquipmentService tradingEquipmentService,
			ILocationService locationService)
		{
			if (view == null) throw new ArgumentNullException(nameof(view));
			if (tradingEquipmentService == null) throw new ArgumentNullException(nameof(tradingEquipmentService));
			if (locationService == null) throw new ArgumentNullException(nameof(locationService));

			_view = view;
			_view.Observer = this;
			_tradingEquipmentService = tradingEquipmentService;
			_locationService = locationService;
		}

		public async void OpenView()
		{
			_view.TradingEquipment = await _tradingEquipmentService.GetAllAsync();
			_view.Locations = await _locationService.GetAllAsync();
			_view.Open();
		}

		public async void MoveTradingEquipmentRequested()
		{
			await _tradingEquipmentService.MoveAsync(
				_view.SelectedTradingEquipment.Id,
				_view.SelectedDestination.Id,
				_view.Amount);
		}
	}
}