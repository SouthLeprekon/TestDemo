using System.Collections.Generic;
using Shared.InfoObjects;

namespace Gui.Modules.MoveTradingEquipment
{
	public interface IMoveTradingEquipmentView : IView
	{
		IMoveTradingEquipmentPresenter Observer { set; }
		IEnumerable<TradingEquipmentInfo> TradingEquipment { set; }
		IEnumerable<LocationInfo> Locations { set; }
		TradingEquipmentInfo SelectedTradingEquipment { get; }
		LocationInfo SelectedDestination { get; }
		int Amount { get; }
	}
}