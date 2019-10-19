using System;
using System.Runtime.InteropServices;

namespace Gui.ExcelExporter
{
	public class ExcelExporter : IExcelExporter
	{
		public void Export(string[][] content, string filePath)
		{
			if (content == null) throw new ArgumentNullException(nameof(content));
			if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentException(nameof(filePath));

			var excel = new Microsoft.Office.Interop.Excel.Application();
			var workbooks = excel.Workbooks;
			var workbook = workbooks.Add(Type.Missing);
			var worksheet = workbook.ActiveSheet;

			AddHeader(content[0], worksheet);
			AddBody(content, worksheet);
			Format(excel, worksheet);

			worksheet.SaveAs(filePath);

			GC.Collect();
			GC.WaitForPendingFinalizers();

			Marshal.FinalReleaseComObject(worksheet);
			workbook.Close();
			Marshal.FinalReleaseComObject(workbook);
			excel.Workbooks.Close();
			Marshal.FinalReleaseComObject(workbooks);
			excel.Application.Quit();
			Marshal.FinalReleaseComObject(excel);
			excel = null;

			GC.Collect();
		}

		private static void AddHeader(string[] header, dynamic worksheet)
		{
			for (var columnIndex = 0; columnIndex < header.Length; columnIndex++)
				worksheet.Cells[1, columnIndex + 1] = header[columnIndex];
		}

		private static void AddBody(string[][] content, dynamic worksheet)
		{
			for (var rowIndex = 1; rowIndex < content.Length; rowIndex++)
			{
				var row = content[rowIndex];
				for (var columnIndex = 0; columnIndex < row.Length; columnIndex++)
					worksheet.Cells[rowIndex + 1, columnIndex + 1] = row[columnIndex];
			}
		}

		private static void Format(dynamic excel, dynamic worksheet)
		{
			worksheet.Rows("1:1").Select();
			excel.Selection.Font.Bold = true;
			worksheet.Cells.Select();
			worksheet.Columns.AutoFit();
			worksheet.Range("A1").Select();
		}
	}
}