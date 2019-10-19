using System;
using Domain;
using Shared.InfoObjects;

namespace WebService.Extensions
{
	public static class TradingEquipmentExtensions
	{
		public static TradingEquipmentInfo ToInfo(this TradingEquipment tradingEquipment)
		{
			if (tradingEquipment == null) throw new ArgumentNullException(nameof(tradingEquipment));

			return new TradingEquipmentInfo
			{
				Id = tradingEquipment.Id,
				Model = tradingEquipment.Model.ToInfo(),
				Provider = tradingEquipment.Provider.ToInfo(),
				Location = tradingEquipment.Location.ToInfo(),
				Purchased = tradingEquipment.Purchased,
				Amount = tradingEquipment.Amount
			};
		}
	}
}