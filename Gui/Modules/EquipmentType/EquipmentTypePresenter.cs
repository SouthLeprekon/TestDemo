using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Gui.Extensions;
using Gui.Services;
using Shared.InfoObjects;

namespace Gui.Modules.EquipmentType
{
	public class EquipmentTypePresenter : IEquipmentTypePresenter
	{
		private readonly IEquipmentTypeView _view;
		private readonly IEquipmentTypeService _equipmentTypeService;

		public EquipmentTypePresenter(IEquipmentTypeView view, IEquipmentTypeService equipmentTypeService)
		{
			if (view == null) throw new ArgumentNullException(nameof(view));
			if (equipmentTypeService == null) throw new ArgumentNullException(nameof(equipmentTypeService));

			_view = view;
			_view.Observer = this;
			_equipmentTypeService = equipmentTypeService;
		}

		public async void OpenView()
		{
			var equipmentTypes = await _equipmentTypeService.GetAllAsync();
			_view.EquipmentTypes = new BindingList<EquipmentTypeInfo>(equipmentTypes.ToList());
			EnableOperations();
			_view.Open();
		}

		public void SelectedEquipmentTypeChanged()
		{
			EnableOperations();
		}

		public void AddEquipmentTypeRequested()
		{
			_view.RequestEquipmentTypeProperties(new EquipmentTypeInfo());
		}

		public void EditEquipmentTypeRequested()
		{
			_view.RequestEquipmentTypeProperties(_view.SelectedEquipmentType);
		}

		public async void RemoveEquipmentTypeRequested()
		{
			if (!_view.RemoveEquipmentTypeConfirmed) return;

			var equipmentType = _view.SelectedEquipmentType;

			if (await _equipmentTypeService.GetIsReferencedAsync(equipmentType.Id))
			{
				_view.ShowEquipmentTypeIsReferencedWarning();
				return;
			}

			await _equipmentTypeService.RemoveAsync(equipmentType.Id);
			_view.EquipmentTypes.Remove(equipmentType);
		}

		public async void EquipmentTypePropertiesAccepted(EquipmentTypeInfo equipmentType)
		{
			if (equipmentType == null) throw new ArgumentNullException(nameof(equipmentType));

			_view.SelectedEquipmentType = await SaveEquipmentTypeAsync(equipmentType);
		}

		private void EnableOperations()
		{
			var equipmentTypeSelected = _view.SelectedEquipmentType != null;
			_view.CanEditEquipmentType = equipmentTypeSelected;
			_view.CanRemoveEquipmentType = equipmentTypeSelected;
		}

		private async Task<EquipmentTypeInfo> SaveEquipmentTypeAsync(EquipmentTypeInfo equipmentType)
		{
			if (_view.EquipmentTypes.All(x => x.Id != equipmentType.Id))
			{
				equipmentType = await _equipmentTypeService.AddAsync(equipmentType);
				_view.EquipmentTypes.Add(equipmentType);
			}
			else
			{
				await _equipmentTypeService.UpdateAsync(equipmentType);
				equipmentType = await _equipmentTypeService.GetAsync(equipmentType.Id);
				_view.EquipmentTypes.AddOrReplace(x => x.Id == equipmentType.Id, equipmentType);
			}

			return equipmentType;
		}
	}
}