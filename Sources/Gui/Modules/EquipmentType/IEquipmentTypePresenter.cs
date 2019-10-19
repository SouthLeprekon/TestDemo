using Shared.InfoObjects;

namespace Gui.Modules.EquipmentType
{
	public interface IEquipmentTypePresenter : IPresenter
	{
		void SelectedEquipmentTypeChanged();
		void AddEquipmentTypeRequested();
		void EditEquipmentTypeRequested();
		void RemoveEquipmentTypeRequested();
		void EquipmentTypePropertiesAccepted(EquipmentTypeInfo equipmentType);
	}
}