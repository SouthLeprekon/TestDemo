using System.Collections.Generic;

namespace Gui.Modules.TradingEquipmentMovementReport
{
	public interface ITradingEquipmentMovementReportView : IView
	{
		ITradingEquipmentMovementReportPresenter Observer { set; }
		IEnumerable<ReportEntry> ReportEntries { get; set; }
		bool CanExportToExcel { set; }
	}
}