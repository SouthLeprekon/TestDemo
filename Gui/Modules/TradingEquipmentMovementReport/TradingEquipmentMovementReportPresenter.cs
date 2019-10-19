using System;
using System.Collections.Generic;
using System.Linq;
using Gui.ReportExporter;
using Gui.Services;

namespace Gui.Modules.TradingEquipmentMovementReport
{
	public class TradingEquipmentMovementReportPresenter : ITradingEquipmentMovementReportPresenter
	{
		private readonly ITradingEquipmentMovementReportView _view;
		private readonly ITradingEquipmentMovementService _tradingEquipmentMovementService;
		private readonly IReportExporter _reportExporter;

		public TradingEquipmentMovementReportPresenter(
			ITradingEquipmentMovementReportView view,
			ITradingEquipmentMovementService tradingEquipmentMovementService,
			IReportExporter reportExporter)
		{
			if (view == null) throw new ArgumentNullException(nameof(view));
			if (tradingEquipmentMovementService == null) throw new ArgumentNullException(nameof(tradingEquipmentMovementService));
			if (reportExporter == null) throw new ArgumentNullException(nameof(reportExporter));

			_view = view;
			_view.Observer = this;
			_tradingEquipmentMovementService = tradingEquipmentMovementService;
			_reportExporter = reportExporter;
		}

		public void OpenView()
		{
			EnableOperations();
			_view.Open();
		}

		public async void ShowReportRequested()
		{
			var tradingEquipmentMovements = await _tradingEquipmentMovementService.GetAllAsync();
			_view.ReportEntries = tradingEquipmentMovements.Select(x => new ReportEntry(x));
			EnableOperations();
		}

		public void ExportToExcelRequested()
		{
			var reportContent = GetReportContent().ToArray();
			_reportExporter.Export(reportContent);
		}

		private void EnableOperations()
		{
			_view.CanExportToExcel = _view.ReportEntries != null && _view.ReportEntries.Any();
		}

		private IEnumerable<string[]> GetReportContent()
		{
			yield return new[]
			{
				"Trading Equipment Model",
				"Equipment Type",
				"Producer",
				"Source",
				"Destination",
				"Date",
				"Amount"
			};

			foreach (var reportEntry in _view.ReportEntries)
				yield return new[]
				{
					reportEntry.TradingEquipmentModel,
					reportEntry.EquipmentType,
					reportEntry.Producer,
					reportEntry.Source,
					reportEntry.Destination,
					reportEntry.Date.ToLongDateString(),
					reportEntry.Amount.ToString()
				};
		}
	}
}