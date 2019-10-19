using System;
using System.ComponentModel;
using System.Windows.Forms;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.Producer
{
	public partial class ProducerView : View, IProducerView
	{
		public ProducerView()
		{
			InitializeComponent();

			dataGridView.AutoGenerateColumns = false;
			dataGridView.SelectionChanged += (sender, args) => Observer.SelectedProducerChanged();
			addToolStripButton.Click += (sender, args) => Observer.AddProducerRequested();
			editToolStripButton.Click += (sender, args) => Observer.EditProducerRequested();
			removeToolStripButton.Click += (sender, args) => Observer.RemoveProducerRequested();
		}

		public IProducerPresenter Observer { private get; set; }

		public BindingList<ProducerInfo> Producers
		{
			get => dataGridView.DataSource as BindingList<ProducerInfo>;
			set => dataGridView.DataSource = value;
		}

		public ProducerInfo SelectedProducer
		{
			get => dataGridView.GetSelectedRowData<ProducerInfo>();
			set => dataGridView.SelectRows<ProducerInfo>(x => x.Id == value.Id);
		}

		public bool CanEditProducer
		{
			set => editToolStripButton.Enabled = value;
		}

		public bool CanRemoveProducer
		{
			set => removeToolStripButton.Enabled = value;
		}

		public bool RemoveProducerConfirmed => ConfirmRemove("Producer");

		public void ShowProducerIsReferencedWarning()
		{
			MessageBox.Show("Producer is referenced and can't be removed", "Producer is referenced", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public void RequestProducerProperties(ProducerInfo producer)
		{
			if (producer == null) throw new ArgumentNullException(nameof(producer));

			using (var dialog = new ProducerDialog(producer))
				if (dialog.ShowDialog() == DialogResult.OK)
					Observer.ProducerPropertiesAccepted(dialog.Producer);
		}

		private void OnDataGridViewDoubleClick(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 0) return;
			Observer.EditProducerRequested();
		}
	}
}