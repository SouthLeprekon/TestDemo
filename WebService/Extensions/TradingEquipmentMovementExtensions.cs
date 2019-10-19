using System;
using Domain;
using Shared.InfoObjects;

namespace WebService.Extensions
{
	public static class TradingEquipmentMovementExtensions
	{
		public static TradingEquipmentMovementInfo ToInfo(this TradingEquipmentMovement tradingEquipmentMovement)
		{
			if (tradingEquipmentMovement == null) throw new ArgumentNullException(nameof(tradingEquipmentMovement));

			return new TradingEquipmentMovementInfo
			{
				Id = tradingEquipmentMovement.Id,
				Model = tradingEquipmentMovement.Model.ToInfo(),
				Source = tradingEquipmentMovement.Source?.ToInfo(),
				Destination = tradingEquipmentMovement.Destination.ToInfo(),
				Date = tradingEquipmentMovement.Date,
				Amount = tradingEquipmentMovement.Amount
			};
		}
	}
}