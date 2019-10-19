using System;
using System.Collections.Generic;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.RegisterTradingEquipment
{
	public partial class RegisterTradingEquipmentView : View, IRegisterTradingEquipmentView
	{
		public RegisterTradingEquipmentView()
		{
			InitializeComponent();

			modelComboBox.RequireValue(errorProvider);
			providerComboBox.RequireValue(errorProvider);
			locationComboBox.RequireValue(errorProvider);

			modelComboBox.TextChanged += (sender, args) => EnableOperations();
			providerComboBox.TextChanged += (sender, args) => EnableOperations();
			locationComboBox.TextChanged += (sender, args) => EnableOperations();
			okButton.Click += (sender, args) => Observer.RegisterTradingEquipmentRequested();
			Load += (sender, args) => Clear();

			EnableOperations();
		}

		public IRegisterTradingEquipmentPresenter Observer { private get; set; }
		public TradingEquipmentModelInfo SelectedTradingEquipmentModel => (TradingEquipmentModelInfo)modelComboBox.SelectedItem;
		public ProviderInfo SelectedProvider => (ProviderInfo)providerComboBox.SelectedItem;
		public LocationInfo SelectedLocation => (LocationInfo)locationComboBox.SelectedItem;
		public DateTime Date => dateTimePicker.Value.Date;
		public int Amount => (int)amountNumericUpDown.Value;

		public IEnumerable<TradingEquipmentModelInfo> TradingEquipmentModels
		{
			set => modelComboBox.SetDataSource(value);
		}

		public IEnumerable<ProviderInfo> Providers
		{
			set => providerComboBox.SetDataSource(value);
		}

		public IEnumerable<LocationInfo> Locations
		{
			set => locationComboBox.SetDataSource(value);
		}

		private void EnableOperations()
		{
			okButton.Enabled = ValidateParameters();
		}

		private bool ValidateParameters()
		{
			return !string.IsNullOrWhiteSpace(modelComboBox.Text)
				&& !string.IsNullOrWhiteSpace(providerComboBox.Text)
				&& !string.IsNullOrWhiteSpace(locationComboBox.Text);
		}

		private void Clear()
		{
			amountNumericUpDown.Value = amountNumericUpDown.Minimum;
		}
	}
}