using System;
using System.ComponentModel;
using System.Windows.Forms;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.Location
{
	public partial class LocationView : View, ILocationView
	{
		public LocationView()
		{
			InitializeComponent();

			dataGridView.AutoGenerateColumns = false;
			dataGridView.SelectionChanged += (sender, args) => Observer.SelectedLocationChanged();
			addToolStripButton.Click += (sender, args) => Observer.AddLocationRequested();
			editToolStripButton.Click += (sender, args) => Observer.EditLocationRequested();
			removeToolStripButton.Click += (sender, args) => Observer.RemoveLocationRequested();
		}

		public ILocationPresenter Observer { private get; set; }

		public BindingList<LocationInfo> Locations
		{
			get => dataGridView.DataSource as BindingList<LocationInfo>;
			set => dataGridView.DataSource = value;
		}

		public LocationInfo SelectedLocation
		{
			get => dataGridView.GetSelectedRowData<LocationInfo>();
			set => dataGridView.SelectRows<LocationInfo>(x => x.Id == value.Id);
		}

		public bool CanEditLocation
		{
			set => editToolStripButton.Enabled = value;
		}

		public bool CanRemoveLocation
		{
			set => removeToolStripButton.Enabled = value;
		}

		public bool RemoveLocationConfirmed => ConfirmRemove("Location");

		public void RequestLocationProperties(LocationInfo location)
		{
			if (location == null) throw new ArgumentNullException(nameof(location));

			using (var dialog = new LocationDialog(location))
				if (dialog.ShowDialog() == DialogResult.OK)
					Observer.LocationPropertiesAccepted(dialog.Location);
		}

		public void ShowLocationIsReferencedWarning()
		{
			MessageBox.Show("Location is referenced and can't be removed", "Location is referenced", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void OnDataGridViewDoubleClick(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 0) return;
			Observer.EditLocationRequested();
		}
	}
}