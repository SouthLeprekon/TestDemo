namespace Gui.Modules.TradingEquipmentMovementReport
{
	public interface ITradingEquipmentMovementReportPresenter : IPresenter
	{
		void ShowReportRequested();
		void ExportToExcelRequested();
	}
}