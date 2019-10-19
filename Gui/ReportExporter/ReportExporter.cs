using System;
using System.Diagnostics;
using System.IO;
using Gui.ExcelExporter;

namespace Gui.ReportExporter
{
	public class ReportExporter : IReportExporter
	{
		private readonly IExcelExporter _excelExporter;

		public ReportExporter(IExcelExporter excelExporter)
		{
			if (excelExporter == null) throw new ArgumentNullException(nameof(excelExporter));

			_excelExporter = excelExporter;
		}

		public void Export(string[][] content)
		{
			if (content == null) throw new ArgumentNullException(nameof(content));

			var filePath = $"{Path.GetTempFileName()}.xlsx";
			_excelExporter.Export(content, filePath);
			Process.Start(filePath);
		}
	}
}