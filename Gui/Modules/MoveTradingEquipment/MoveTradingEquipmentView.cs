using System;
using System.Collections.Generic;
using System.Linq;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.MoveTradingEquipment
{
	public partial class MoveTradingEquipmentView : View, IMoveTradingEquipmentView
	{
		public MoveTradingEquipmentView()
		{
			InitializeComponent();

			equipmentComboBox.RequireValue(errorProvider);
			destinationComboBox.RequireValue(errorProvider);

			destinationComboBox.TextChanged += (sender, args) => EnableOperations();
			okButton.Click += (sender, args) => Observer.MoveTradingEquipmentRequested();
			Load += (sender, args) => Clear();

			EnableOperations();
		}

		public IMoveTradingEquipmentPresenter Observer { private get; set; }
		public TradingEquipmentInfo SelectedTradingEquipment => (equipmentComboBox.SelectedItem as TradingEquipmentDisplayInfo)?.TradingEquipment;
		public LocationInfo SelectedDestination => (LocationInfo)destinationComboBox.SelectedItem;
		public int Amount => (int)amountNumericUpDown.Value;

		public IEnumerable<TradingEquipmentInfo> TradingEquipment
		{
			set => equipmentComboBox.SetDataSource(value.Select(x => new TradingEquipmentDisplayInfo(x)));
		}

		public IEnumerable<LocationInfo> Locations
		{
			private get => sourceComboBox.DataSource as IEnumerable<LocationInfo>;
			set => sourceComboBox.SetDataSource(value);
		}

		private void EnableOperations()
		{
			okButton.Enabled = ValidateParameters();
		}

		private bool ValidateParameters()
		{
			return !string.IsNullOrWhiteSpace(equipmentComboBox.Text)
				&& !string.IsNullOrWhiteSpace(destinationComboBox.Text);
		}

		private void OnEquipmentComboBoxTextChanged(object sender, EventArgs e)
		{
			if (Locations == null) return;

			if (string.IsNullOrEmpty(equipmentComboBox.Text))
			{
				sourceComboBox.SelectedValue = -1;
				destinationComboBox.SelectedValue = -1;
			}
			else
			{
				var displayInfo = (TradingEquipmentDisplayInfo)equipmentComboBox.SelectedItem;
				var sourceLocationId = displayInfo.TradingEquipment.Location.Id;
				sourceComboBox.SelectedValue = sourceLocationId;
				destinationComboBox.SetDataSource(Locations.Where(x => x.Id != sourceLocationId));
				availableNumericUpDown.Value = displayInfo.TradingEquipment.Amount;
				amountNumericUpDown.Maximum = displayInfo.TradingEquipment.Amount;
			}

			EnableOperations();
		}

		private void Clear()
		{
			availableNumericUpDown.Value = 0;
			amountNumericUpDown.Value = amountNumericUpDown.Minimum;
		}
	}
}