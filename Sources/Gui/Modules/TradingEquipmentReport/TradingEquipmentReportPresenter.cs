using System;
using System.Collections.Generic;
using System.Linq;
using Gui.ReportExporter;
using Gui.Services;

namespace Gui.Modules.TradingEquipmentReport
{
	public class TradingEquipmentReportPresenter : ITradingEquipmentReportPresenter
	{
		private readonly ITradingEquipmentReportView _view;
		private readonly ITradingEquipmentService _tradingEquipmentService;
		private readonly IReportExporter _reportExporter;

		public TradingEquipmentReportPresenter(
			ITradingEquipmentReportView view,
			ITradingEquipmentService tradingEquipmentService,
			IReportExporter reportExporter)
		{
			if (view == null) throw new ArgumentNullException(nameof(view));
			if (tradingEquipmentService == null) throw new ArgumentNullException(nameof(tradingEquipmentService));
			if (reportExporter == null) throw new ArgumentNullException(nameof(reportExporter));

			_view = view;
			_view.Observer = this;
			_tradingEquipmentService = tradingEquipmentService;
			_reportExporter = reportExporter;
		}

		public void OpenView()
		{
			EnableOperations();
			_view.Open();
		}

		public async void ShowReportRequested()
		{
			var tradingEquipment = await _tradingEquipmentService.GetAsync(_view.MinPurchaseDate);
			_view.ReportEntries = tradingEquipment.Select(x => new ReportEntry(x));
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
				"Provider",
				"Location",
				"Purchased",
				"Amount"
			};

			foreach (var reportEntry in _view.ReportEntries)
				yield return new[]
				{
					reportEntry.TradingEquipmentModel,
					reportEntry.EquipmentType,
					reportEntry.Producer,
					reportEntry.Provider,
					reportEntry.Location,
					reportEntry.Purchased.ToShortDateString(),
					reportEntry.Amount.ToString()
				};
		}
	}
}