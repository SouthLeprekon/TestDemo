using Shared.InfoObjects;

namespace Gui.Modules.TradingEquipmentModel
{
	public interface ITradingEquipmentModelPresenter : IPresenter
	{
		void SelectedTradingEquipmentModelChanged();
		void AddTradingEquipmentModelRequested();
		void EditTradingEquipmentModelRequested();
		void RemoveTradingEquipmentModelRequested();
		void TradingEquipmentModelPropertiesAccepted(TradingEquipmentModelInfo tradingEquipmentModel);
	}
}