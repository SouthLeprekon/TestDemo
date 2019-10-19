using System;
using System.Windows.Forms;
using Gui.Extensions;
using Shared.InfoObjects;

namespace Gui.Modules.Location
{
	public partial class LocationDialog : Form
	{
		private readonly long _id;

		public LocationDialog(LocationInfo location)
		{
			if (location == null) throw new ArgumentNullException(nameof(location));

			InitializeComponent();

			_id = location.Id;
			bindingSource.DataSource = location;
			nameTextBox.RequireValue(errorProvider);
			addressTextBox.RequireValue(errorProvider);

			nameTextBox.TextChanged += (sender, args) => EnableOperations();
			addressTextBox.TextChanged += (sender, args) => EnableOperations();
			EnableOperations();
		}

		public new LocationInfo Location => new LocationInfo
		{
			Id = _id,
			Name = nameTextBox.Text,
			Address = addressTextBox.Text
		};

		private void EnableOperations()
		{
			okButton.Enabled = ValidateLocation();
		}

		private bool ValidateLocation()
		{
			return !string.IsNullOrWhiteSpace(nameTextBox.Text)
				&& !string.IsNullOrWhiteSpace(addressTextBox.Text);
		}
	}
}