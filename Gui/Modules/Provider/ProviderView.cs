using System;
using System.ComponentModel;
using System.Windows.Forms;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.Provider
{
	public partial class ProviderView : View, IProviderView
	{
		public ProviderView()
		{
			InitializeComponent();

			dataGridView.AutoGenerateColumns = false;
			dataGridView.SelectionChanged += (sender, args) => Observer.SelectedProviderChanged();
			addToolStripButton.Click += (sender, args) => Observer.AddProviderRequested();
			editToolStripButton.Click += (sender, args) => Observer.EditProviderRequested();
			removeToolStripButton.Click += (sender, args) => Observer.RemoveProviderRequested();
		}

		public IProviderPresenter Observer { private get; set; }

		public BindingList<ProviderInfo> Providers
		{
			get => dataGridView.DataSource as BindingList<ProviderInfo>;
			set => dataGridView.DataSource = value;
		}

		public ProviderInfo SelectedProvider
		{
			get => dataGridView.GetSelectedRowData<ProviderInfo>();
			set => dataGridView.SelectRows<ProviderInfo>(x => x.Id == value.Id);
		}

		public bool CanEditProvider
		{
			set => editToolStripButton.Enabled = value;
		}

		public bool CanRemoveProvider
		{
			set => removeToolStripButton.Enabled = value;
		}

		public bool RemoveProviderConfirmed => ConfirmRemove("Provider");

		public void RequestProviderProperties(ProviderInfo provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			using (var dialog = new ProviderDialog(provider))
				if (dialog.ShowDialog() == DialogResult.OK)
					Observer.ProviderPropertiesAccepted(dialog.Provider);
		}

		public void ShowProviderIsReferencedWarning()
		{
			MessageBox.Show("Provider is referenced and can't be removed", "Provider is referenced", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void OnDataGridViewDoubleClick(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 0) return;
			Observer.EditProviderRequested();
		}
	}
}