using System.Collections.Generic;
using System.ComponentModel;
using Shared.InfoObjects;

namespace Gui.Modules.TradingEquipmentModel
{
	public interface ITradingEquipmentModelView : IView
	{
		ITradingEquipmentModelPresenter Observer { set; }
		IEnumerable<EquipmentTypeInfo> EquipmentTypes { set; }
		IEnumerable<ProducerInfo> Producers { set; }
		BindingList<TradingEquipmentModelDisplayInfo> TradingEquipmentModels { get; set; }
		TradingEquipmentModelDisplayInfo SelectedTradingEquipmentModel { get; set; }
		bool CanEditTradingEquipmentModel { set; }
		bool CanRemoveTradingEquipmentModel { set; }
		bool RemoveTradingEquipmentModelConfirmed { get; }
		void RequestTradingEquipmentModelProperties(TradingEquipmentModelInfo tradingEquipmentModel);
		void ShowTradingEquipmentModelIsReferencedWarning();
	}
}