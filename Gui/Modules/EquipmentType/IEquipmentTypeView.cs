using System.ComponentModel;
using Shared.InfoObjects;

namespace Gui.Modules.EquipmentType
{
	public interface IEquipmentTypeView : IView
	{
		IEquipmentTypePresenter Observer { set; }
		BindingList<EquipmentTypeInfo> EquipmentTypes { get; set; }
		EquipmentTypeInfo SelectedEquipmentType { get; set; }
		bool CanEditEquipmentType { set; }
		bool CanRemoveEquipmentType { set; }
		bool RemoveEquipmentTypeConfirmed { get; }
		void ShowEquipmentTypeIsReferencedWarning();
		void RequestEquipmentTypeProperties(EquipmentTypeInfo equipmentType);
	}
}