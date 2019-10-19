using System;
using System.Collections.Generic;
using System.Linq;

namespace Gui.Modules.TradingEquipmentReport
{
	public partial class TradingEquipmentReportView : View, ITradingEquipmentReportView
	{
		public TradingEquipmentReportView()
		{
			InitializeComponent();

			dataGridView.AutoGenerateColumns = false;
			showButton.Click += (sender, args) => Observer.ShowReportRequested();
			toExcelButton.Click += (sender, args) => Observer.ExportToExcelRequested();
			Load += (sender, args) => Clear();
		}

		public ITradingEquipmentReportPresenter Observer { private get; set; }
		public DateTime MinPurchaseDate => minPurchaseDateTimePicker.Value.Date;

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