using System;
using System.Windows.Forms;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.Provider
{
	public partial class ProviderDialog : Form
	{
		private readonly long _id;

		public ProviderDialog(ProviderInfo provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			InitializeComponent();

			_id = provider.Id;
			bindingSource.DataSource = provider;
			nameTextBox.RequireValue(errorProvider);
			addressTextBox.RequireValue(errorProvider);

			nameTextBox.TextChanged += (sender, args) => EnableOperations();
			addressTextBox.TextChanged += (sender, args) => EnableOperations();
			EnableOperations();
		}

		public ProviderInfo Provider => new ProviderInfo
		{
			Id = _id,
			Name = nameTextBox.Text,
			Address = addressTextBox.Text
		};

		private void EnableOperations()
		{
			okButton.Enabled = ValidateProvider();
		}

		private bool ValidateProvider()
		{
			return !string.IsNullOrWhiteSpace(nameTextBox.Text)
				&& !string.IsNullOrWhiteSpace(addressTextBox.Text);
		}
	}
}