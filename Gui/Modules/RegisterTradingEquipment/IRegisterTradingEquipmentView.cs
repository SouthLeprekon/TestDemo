using System;
using System.Collections.Generic;
using Shared.InfoObjects;

namespace Gui.Modules.RegisterTradingEquipment
{
	public interface IRegisterTradingEquipmentView : IView
	{
		IRegisterTradingEquipmentPresenter Observer { set; }
		IEnumerable<TradingEquipmentModelInfo> TradingEquipmentModels { set; }
		IEnumerable<ProviderInfo> Providers { set; }
		IEnumerable<LocationInfo> Locations { set; }
		TradingEquipmentModelInfo SelectedTradingEquipmentModel { get; }
		ProviderInfo SelectedProvider { get; }
		LocationInfo SelectedLocation { get; }
		DateTime Date { get; }
		int Amount { get; }
	}
}