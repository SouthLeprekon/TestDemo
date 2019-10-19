using System;
using Shared.InfoObjects;

namespace Gui.Modules.TradingEquipmentMovementReport
{
	public class ReportEntry
	{
		public ReportEntry(TradingEquipmentMovementInfo tradingEquipmentMovement)
		{
			if (tradingEquipmentMovement == null) throw new ArgumentNullException(nameof(tradingEquipmentMovement));

			TradingEquipmentModel = tradingEquipmentMovement.Model.Name;
			EquipmentType = tradingEquipmentMovement.Model.Type.Name;
			Producer = tradingEquipmentMovement.Model.Producer.Name;
			Source = tradingEquipmentMovement.Source?.Name ?? "Just Purchased";
			Destination = tradingEquipmentMovement.Destination.Name;
			Date = tradingEquipmentMovement.Date;
			Amount = tradingEquipmentMovement.Amount;
		}

		public string TradingEquipmentModel { get; }
		public string EquipmentType { get; }
		public string Producer { get; }
		public string Source { get; }
		public string Destination { get; }
		public DateTime Date { get; }
		public int Amount { get; }
	}
}