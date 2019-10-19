using System.Windows.Forms;

namespace Gui.Modules
{
	public class View : Form, IView
	{
		public void Open()
		{
			ShowDialog();
		}

		protected bool ConfirmRemove(string entityTypeName)
		{
			var message = $"Are you sure you want to remove {entityTypeName}?";
			var caption = $"Remove {entityTypeName}";
			return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
		}
	}
}