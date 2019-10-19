using System;
using Domain;
using Shared.InfoObjects;

namespace WebService.Extensions
{
	public static class TradingEquipmentModelExtensions
	{
		public static TradingEquipmentModelInfo ToInfo(this TradingEquipmentModel tradingEquipmentModel)
		{
			if (tradingEquipmentModel == null) throw new ArgumentNullException(nameof(tradingEquipmentModel));

			return new TradingEquipmentModelInfo
			{
				Id = tradingEquipmentModel.Id,
				Name = tradingEquipmentModel.Name,
				Type = tradingEquipmentModel.Type.ToInfo(),
				Producer = tradingEquipmentModel.Producer.ToInfo()
			};
		}
	}
}