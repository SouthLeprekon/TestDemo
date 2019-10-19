using System;
using System.Windows.Forms;
using StructureMap;

namespace Gui
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var container = InitializeContainer();
			var mainForm = container.GetInstance<MainForm>();
			Application.Run(mainForm);
		}

		private static Container InitializeContainer()
		{
			return new Container(_ => _.Scan(x =>
			{
				x.TheCallingAssembly();
				x.WithDefaultConventions();
			}));
		}
	}
}