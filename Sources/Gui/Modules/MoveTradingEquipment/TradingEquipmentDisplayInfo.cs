using System;
using System.Collections.Generic;
using System.Globalization;
using Shared.InfoObjects;

namespace Gui.Modules.MoveTradingEquipment
{
	public class TradingEquipmentDisplayInfo
	{
		private static readonly string _dateFormat = CultureInfo.InvariantCulture.DateTimeFormat.ShortDatePattern;

		public TradingEquipmentDisplayInfo(TradingEquipmentInfo tradingEquipment)
		{
			if (tradingEquipment == null) throw new ArgumentNullException(nameof(tradingEquipment));

			TradingEquipment = tradingEquipment;
		}

		public TradingEquipmentInfo TradingEquipment { get; }
		public string Description => GetDescription(TradingEquipment);

		private static string GetDescription(TradingEquipmentInfo tradingEquipment)
		{
			return string.Join(" - ", GetDescriptionComponents(tradingEquipment));
		}

		private static IEnumerable<string> GetDescriptionComponents(TradingEquipmentInfo tradingEquipment)
		{
			yield return tradingEquipment.Model.Name;
			yield return tradingEquipment.Purchased.ToString(_dateFormat);
			yield return tradingEquipment.Location.Name;
			yield return tradingEquipment.Amount.ToString();
		}
	}
}