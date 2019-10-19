using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gui.Extensions
{
	public static class ComboBoxExtensions
	{
		public static void SetDataSource<T>(this ComboBox comboBox, IEnumerable<T> dataSource)
		{
			if (comboBox == null) throw new ArgumentNullException(nameof(comboBox));

			comboBox.DataSource = dataSource.ToList();
			comboBox.SelectedValue = -1;
		}

		public static void RequireValue(this ComboBox comboBox, ErrorProvider errorProvider, string errorMessage = "Required")
		{
			if (comboBox == null) throw new ArgumentNullException(nameof(comboBox));
			if (errorProvider == null) throw new ArgumentNullException(nameof(errorProvider));

			comboBox.UpdateError(errorProvider, errorMessage);
			comboBox.TextChanged += (sender, args) => comboBox.UpdateError(errorProvider, errorMessage);
		}

		private static void UpdateError(this ComboBox comboBox, ErrorProvider errorProvider, string errorMessage)
		{
			errorProvider.SetError(comboBox, string.IsNullOrWhiteSpace(comboBox.Text) ? errorMessage : null);
		}
	}
}