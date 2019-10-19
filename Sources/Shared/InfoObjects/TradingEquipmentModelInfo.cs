namespace Shared.InfoObjects
{
	public class TradingEquipmentModelInfo : InfoObject
	{
		public string Name { get; set; }
		public EquipmentTypeInfo Type { get; set; }
		public ProducerInfo Producer { get; set; }
	}
}