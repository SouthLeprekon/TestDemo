using System;

namespace Domain
{
	public class TradingEquipment : Entity
	{
		public TradingEquipmentModel Model { get; set; }
		public Provider Provider { get; set; }
		public Location Location { get; set; }
		public DateTime Purchased { get; set; }
		public int Amount { get; set; }
	}
}