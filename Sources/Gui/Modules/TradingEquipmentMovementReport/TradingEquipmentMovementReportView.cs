using System.Collections.Generic;
using System.Linq;

namespace Gui.Modules.TradingEquipmentMovementReport
{
	public partial class TradingEquipmentMovementReportView : View, ITradingEquipmentMovementReportView
	{
		public TradingEquipmentMovementReportView()
		{
			InitializeComponent();

			dataGridView.AutoGenerateColumns = false;
			showButton.Click += (sender, args) => Observer.ShowReportRequested();
			toExcelButton.Click += (sender, args) => Observer.ExportToExcelRequested();
			Load += (sender, args) => Clear();
		}

		public ITradingEquipmentMovementReportPresenter Observer { private get; set; }

		public IEnumerable<ReportEntry> ReportEntries
		{
			get => dataGridView.DataSource as IEnumerable<ReportEntry>;
			set => dataGridView.DataSource = value?.ToList();
		}

		public bool CanExportToExcel
		{
			set => toExcelButton.Enabled = value;
		}

		private void Clear()
		{
			ReportEntries = null;
		}
	}
}