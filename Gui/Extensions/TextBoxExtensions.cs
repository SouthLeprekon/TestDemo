using System;
using System.Windows.Forms;

namespace Gui.Extensions
{
	public static class TextBoxExtensions
	{
		public static void RequireValue(this TextBox textBox, ErrorProvider errorProvider, string errorMessage = "Required")
		{
			if (textBox == null) throw new ArgumentNullException(nameof(textBox));
			if (errorProvider == null) throw new ArgumentNullException(nameof(errorProvider));

			textBox.UpdateError(errorProvider, errorMessage);
			textBox.TextChanged += (sender, args) => textBox.UpdateError(errorProvider, errorMessage);
		}

		private static void UpdateError(this TextBox textBox, ErrorProvider errorProvider, string errorMessage)
		{
			errorProvider.SetError(textBox, string.IsNullOrWhiteSpace(textBox.Text) ? errorMessage : null);
		}
	}
}