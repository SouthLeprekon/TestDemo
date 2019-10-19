namespace Gui.Modules.TradingEquipmentReport
{
	public interface ITradingEquipmentReportPresenter : IPresenter
	{
		void ShowReportRequested();
		void ExportToExcelRequested();
	}
}