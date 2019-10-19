namespace Gui.ExcelExporter
{
	public interface IExcelExporter
	{
		void Export(string[][] content, string filePath);
	}
}