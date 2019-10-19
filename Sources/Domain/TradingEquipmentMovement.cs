using System;

namespace Domain
{
	public class TradingEquipmentMovement : Entity
	{
		public TradingEquipmentModel Model { get; set; }
		public Location Source { get; set; }
		public Location Destination { get; set; }
		public DateTime Date { get; set; }
		public int Amount { get; set; }
	}
}