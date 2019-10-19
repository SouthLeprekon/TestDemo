namespace Domain
{
	public class TradingEquipmentModel : Entity
	{
		public string Name { get; set; }
		public EquipmentType Type { get; set; }
		public Producer Producer { get; set; }
	}
}