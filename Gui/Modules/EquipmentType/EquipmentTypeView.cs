using System;
using System.ComponentModel;
using System.Windows.Forms;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.EquipmentType
{
	public partial class EquipmentTypeView : View, IEquipmentTypeView
	{
		public EquipmentTypeView()
		{
			InitializeComponent();

			dataGridView.AutoGenerateColumns = false;
			dataGridView.SelectionChanged += (sender, args) => Observer.SelectedEquipmentTypeChanged();
			addToolStripButton.Click += (sender, args) => Observer.AddEquipmentTypeRequested();
			editToolStripButton.Click += (sender, args) => Observer.EditEquipmentTypeRequested();
			removeToolStripButton.Click += (sender, args) => Observer.RemoveEquipmentTypeRequested();
		}

		public IEquipmentTypePresenter Observer { private get; set; }

		public BindingList<EquipmentTypeInfo> EquipmentTypes
		{
			get => dataGridView.DataSource as BindingList<EquipmentTypeInfo>;
			set => dataGridView.DataSource = value;
		}

		public EquipmentTypeInfo SelectedEquipmentType
		{
			get => dataGridView.GetSelectedRowData<EquipmentTypeInfo>();
			set => dataGridView.SelectRows<EquipmentTypeInfo>(x => x.Id == value.Id);
		}

		public bool CanEditEquipmentType
		{
			set => editToolStripButton.Enabled = value;
		}

		public bool CanRemoveEquipmentType
		{
			set => removeToolStripButton.Enabled = value;
		}

		public bool RemoveEquipmentTypeConfirmed => ConfirmRemove("Equipment Type");

		public void ShowEquipmentTypeIsReferencedWarning()
		{
			MessageBox.Show("Equipment Type is referenced and can't be removed", "Equipment Type is referenced", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public void RequestEquipmentTypeProperties(EquipmentTypeInfo equipmentType)
		{
			if (equipmentType == null) throw new ArgumentNullException(nameof(equipmentType));

			using (var dialog = new EquipmentTypeDialog(equipmentType))
				if (dialog.ShowDialog() == DialogResult.OK)
					Observer.EquipmentTypePropertiesAccepted(dialog.EquipmentType);
		}

		private void OnDataGridViewDoubleClick(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 0) return;
			Observer.EditEquipmentTypeRequested();
		}
	}
}