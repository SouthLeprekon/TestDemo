using System;
using System.Windows.Forms;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.Producer
{
	public partial class ProducerDialog : Form
	{
		private readonly long _id;

		public ProducerDialog(ProducerInfo producer)
		{
			if (producer == null) throw new ArgumentNullException(nameof(producer));

			InitializeComponent();

			_id = producer.Id;
			bindingSource.DataSource = producer;
			nameTextBox.RequireValue(errorProvider);
			addressTextBox.RequireValue(errorProvider);

			nameTextBox.TextChanged += (sender, args) => EnableOperations();
			addressTextBox.TextChanged += (sender, args) => EnableOperations();
			EnableOperations();
		}

		public ProducerInfo Producer => new ProducerInfo
		{
			Id = _id,
			Name = nameTextBox.Text,
			Address = addressTextBox.Text
		};

		private void EnableOperations()
		{
			okButton.Enabled = ValidateProducer();
		}

		private bool ValidateProducer()
		{
			return !string.IsNullOrWhiteSpace(nameTextBox.Text)
				&& !string.IsNullOrWhiteSpace(addressTextBox.Text);
		}
	}
}