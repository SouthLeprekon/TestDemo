using System;
using System.Windows.Forms;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.EquipmentType
{
	public partial class EquipmentTypeDialog : Form
	{
		private readonly long _id;

		public EquipmentTypeDialog(EquipmentTypeInfo equipmentType)
		{
			if (equipmentType == null) throw new ArgumentNullException(nameof(equipmentType));

			InitializeComponent();

			_id = equipmentType.Id;
			bindingSource.DataSource = equipmentType;
			nameTextBox.RequireValue(errorProvider);

			nameTextBox.TextChanged += (sender, args) => EnableOperations();
			EnableOperations();
		}

		public EquipmentTypeInfo EquipmentType => new EquipmentTypeInfo
		{
			Id = _id,
			Name = nameTextBox.Text
		};

		private void EnableOperations()
		{
			okButton.Enabled = ValidateEquipmentType();
		}

		private bool ValidateEquipmentType()
		{
			return !string.IsNullOrWhiteSpace(nameTextBox.Text);
		}
	}
}