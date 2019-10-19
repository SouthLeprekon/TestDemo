using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.TradingEquipmentModel
{
	public partial class TradingEquipmentModelView : View, ITradingEquipmentModelView
	{
		public TradingEquipmentModelView()
		{
			InitializeComponent();

			dataGridView.AutoGenerateColumns = false;
			dataGridView.SelectionChanged += (sender, args) => Observer.SelectedTradingEquipmentModelChanged();
			addToolStripButton.Click += (sender, args) => Observer.AddTradingEquipmentModelRequested();
			editToolStripButton.Click += (sender, args) => Observer.EditTradingEquipmentModelRequested();
			removeToolStripButton.Click += (sender, args) => Observer.RemoveTradingEquipmentModelRequested();
		}

		public ITradingEquipmentModelPresenter Observer { private get; set; }
		public IEnumerable<EquipmentTypeInfo> EquipmentTypes { private get; set; }
		public IEnumerable<ProducerInfo> Producers { private get; set; }

		public BindingList<TradingEquipmentModelDisplayInfo> TradingEquipmentModels
		{
			get => dataGridView.DataSource as BindingList<TradingEquipmentModelDisplayInfo>;
			set => dataGridView.DataSource = value;
		}

		public TradingEquipmentModelDisplayInfo SelectedTradingEquipmentModel
		{
			get => dataGridView.GetSelectedRowData<TradingEquipmentModelDisplayInfo>();
			set => dataGridView.SelectRows<TradingEquipmentModelDisplayInfo>(x => x.Id == value.Id);
		}

		public bool CanEditTradingEquipmentModel
		{
			set => editToolStripButton.Enabled = value;
		}

		public bool CanRemoveTradingEquipmentModel
		{
			set => removeToolStripButton.Enabled = value;
		}

		public bool RemoveTradingEquipmentModelConfirmed => ConfirmRemove("Trading Equipment Type");

		public void RequestTradingEquipmentModelProperties(TradingEquipmentModelInfo tradingEquipmentModel)
		{
			if (tradingEquipmentModel == null) throw new ArgumentNullException(nameof(tradingEquipmentModel));

			using (var dialog = new TradingEquipmentModelDialog(tradingEquipmentModel, EquipmentTypes, Producers))
				if (dialog.ShowDialog() == DialogResult.OK)
					Observer.TradingEquipmentModelPropertiesAccepted(dialog.TradingEquipmentModel);
		}

		public void ShowTradingEquipmentModelIsReferencedWarning()
		{
			MessageBox.Show("Trading Equipment Model is referenced and can't be removed", "Trading Equipment Model is referenced", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void OnDataGridViewDoubleClick(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 0) return;
			Observer.EditTradingEquipmentModelRequested();
		}
	}
}