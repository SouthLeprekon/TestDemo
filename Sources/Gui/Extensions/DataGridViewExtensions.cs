using System;
using System.Linq;
using System.Windows.Forms;

namespace Gui.Extensions
{
	internal static class DataGridViewExtensions
	{
		public static T GetSelectedRowData<T>(this DataGridView dataGridView)
		{
			if (dataGridView == null) throw new ArgumentNullException(nameof(dataGridView));

			if (dataGridView.SelectedRows.Count == 0) return default;
			return (T)dataGridView.SelectedRows[0].DataBoundItem;
		}

		public static void SelectRows<T>(this DataGridView dataGridView, Func<T, bool> predicate)
		{
			if (dataGridView == null) throw new ArgumentNullException(nameof(dataGridView));
			if (predicate == null) throw new ArgumentNullException(nameof(predicate));

			foreach (var row in dataGridView.Rows.OfType<DataGridViewRow>())
				row.Selected = predicate((T)row.DataBoundItem);
		}
	}
}