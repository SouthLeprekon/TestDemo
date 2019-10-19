using System;

namespace Shared.InfoObjects
{
	public class TradingEquipmentInfo : InfoObject
	{
		public TradingEquipmentModelInfo Model { get; set; }
		public ProviderInfo Provider { get; set; }
		public LocationInfo Location { get; set; }
		public DateTime Purchased { get; set; }
		public int Amount { get; set; }
	}
}