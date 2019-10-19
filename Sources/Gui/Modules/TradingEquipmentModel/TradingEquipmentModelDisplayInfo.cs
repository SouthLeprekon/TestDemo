using System;
using Shared.InfoObjects;

namespace Gui.Modules.TradingEquipmentModel
{
	public class TradingEquipmentModelDisplayInfo
	{
		public TradingEquipmentModelDisplayInfo(TradingEquipmentModelInfo tradingEquipmentModel)
		{
			if (tradingEquipmentModel == null) throw new ArgumentNullException(nameof(tradingEquipmentModel));

			TradingEquipmentModel = tradingEquipmentModel;
		}

		public long Id => TradingEquipmentModel.Id;
		public string Name => TradingEquipmentModel.Name;
		public string Type => TradingEquipmentModel.Type.Name;
		public string Producer => TradingEquipmentModel.Producer.Name;
		public TradingEquipmentModelInfo TradingEquipmentModel { get; }
	}
}