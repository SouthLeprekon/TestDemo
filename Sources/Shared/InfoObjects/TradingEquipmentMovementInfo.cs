using System;

namespace Shared.InfoObjects
{
	public class TradingEquipmentMovementInfo : InfoObject
	{
		public TradingEquipmentModelInfo Model { get; set; }
		public LocationInfo Source { get; set; }
		public LocationInfo Destination { get; set; }
		public DateTime Date { get; set; }
		public int Amount { get; set; }
	}
}