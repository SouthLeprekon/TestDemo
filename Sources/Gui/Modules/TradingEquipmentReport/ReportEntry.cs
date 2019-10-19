using System;
using Shared.InfoObjects;

namespace Gui.Modules.TradingEquipmentReport
{
	public class ReportEntry
	{
		public ReportEntry(TradingEquipmentInfo tradingEquipment)
		{
			if (tradingEquipment == null) throw new ArgumentNullException(nameof(tradingEquipment));

			TradingEquipmentModel = tradingEquipment.Model.Name;
			EquipmentType = tradingEquipment.Model.Type.Name;
			Producer = tradingEquipment.Model.Producer.Name;
			Provider = tradingEquipment.Provider.Name;
			Location = tradingEquipment.Location.Name;
			Purchased = tradingEquipment.Purchased;
			Amount = tradingEquipment.Amount;
		}

		public string TradingEquipmentModel { get; }
		public string EquipmentType { get; }
		public string Producer { get; }
		public string Provider { get; }
		public string Location { get; }
		public DateTime Purchased { get; }
		public int Amount { get; }
	}
}