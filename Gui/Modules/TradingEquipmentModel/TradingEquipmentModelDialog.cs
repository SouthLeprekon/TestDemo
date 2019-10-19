using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.TradingEquipmentModel
{
	public partial class TradingEquipmentModelDialog : Form
	{
		private readonly long _id;

		public TradingEquipmentModelDialog(TradingEquipmentModelInfo tradingEquipmentModel, IEnumerable<EquipmentTypeInfo> equipmentTypes, IEnumerable<ProducerInfo> producers)
		{
			if (tradingEquipmentModel == null) throw new ArgumentNullException(nameof(tradingEquipmentModel));
			if (equipmentTypes == null) throw new ArgumentNullException(nameof(equipmentTypes));
			if (producers == null) throw new ArgumentNullException(nameof(producers));

			InitializeComponent();

			_id = tradingEquipmentModel.Id;
			bindingSource.DataSource = tradingEquipmentModel;
			typeComboBox.DataSource = equipmentTypes.ToList();
			producerComboBox.DataSource = producers.ToList();
			typeComboBox.SelectedValue = tradingEquipmentModel.Type?.Id ?? -1;
			producerComboBox.SelectedValue = tradingEquipmentModel.Producer?.Id ?? -1;

			nameTextBox.RequireValue(errorProvider);
			typeComboBox.RequireValue(errorProvider);
			producerComboBox.RequireValue(errorProvider);

			nameTextBox.TextChanged += (sender, args) => EnableOperations();
			typeComboBox.TextChanged += (sender, args) => EnableOperations();
			producerComboBox.TextChanged += (sender, args) => EnableOperations();

			EnableOperations();
		}

		public TradingEquipmentModelInfo TradingEquipmentModel => new TradingEquipmentModelInfo
		{
			Id = _id,
			Name = nameTextBox.Text,
			Type = (EquipmentTypeInfo)typeComboBox.SelectedItem,
			Producer = (ProducerInfo)producerComboBox.SelectedItem
		};

		private void EnableOperations()
		{
			okButton.Enabled = ValidateTradingEquipmentModel();
		}

		private bool ValidateTradingEquipmentModel()
		{
			return !string.IsNullOrWhiteSpace(nameTextBox.Text)
				&& !string.IsNullOrWhiteSpace(typeComboBox.Text)
				&& !string.IsNullOrWhiteSpace(producerComboBox.Text);
		}
	}
}