using System;
using System.Collections.Generic;

namespace Gui.Modules.TradingEquipmentReport
{
	public interface ITradingEquipmentReportView : IView
	{
		ITradingEquipmentReportPresenter Observer { set; }
		IEnumerable<ReportEntry> ReportEntries { get; set; }
		DateTime MinPurchaseDate { get; }
		bool CanExportToExcel { set; }
	}
}