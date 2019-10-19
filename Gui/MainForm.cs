using System;
using System.Windows.Forms;
using Gui.Modules;
using Gui.Modules.EquipmentType;
using Gui.Modules.Location;
using Gui.Modules.MoveTradingEquipment;
using Gui.Modules.Producer;
using Gui.Modules.Provider;
using Gui.Modules.RegisterTradingEquipment;
using Gui.Modules.TradingEquipmentModel;
using Gui.Modules.TradingEquipmentMovementReport;
using Gui.Modules.TradingEquipmentReport;

namespace Gui
{
	public partial class MainForm : Form
	{
		public MainForm(
			IProducerPresenter producerPresenter,
			IProviderPresenter providerPresenter,
			IEquipmentTypePresenter equipmentTypePresenter,
			ITradingEquipmentModelPresenter tradingEquipmentModelPresenter,
			ILocationPresenter locationPresenter,
			IRegisterTradingEquipmentPresenter registerTradingEquipmentPresenter,
			IMoveTradingEquipmentPresenter moveTradingEquipmentPresenter,
			ITradingEquipmentReportPresenter tradingEquipmentReportPresenter,
			ITradingEquipmentMovementReportPresenter tradingEquipmentMovementReportPresenter)
		{
			if (producerPresenter == null) throw new ArgumentNullException(nameof(producerPresenter));
			if (providerPresenter == null) throw new ArgumentNullException(nameof(providerPresenter));
			if (equipmentTypePresenter == null) throw new ArgumentNullException(nameof(equipmentTypePresenter));
			if (tradingEquipmentModelPresenter == null) throw new ArgumentNullException(nameof(tradingEquipmentModelPresenter));
			if (locationPresenter == null) throw new ArgumentNullException(nameof(locationPresenter));
			if (registerTradingEquipmentPresenter == null) throw new ArgumentNullException(nameof(registerTradingEquipmentPresenter));
			if (moveTradingEquipmentPresenter == null) throw new ArgumentNullException(nameof(moveTradingEquipmentPresenter));
			if (tradingEquipmentReportPresenter == null) throw new ArgumentNullException(nameof(tradingEquipmentReportPresenter));
			if (tradingEquipmentMovementReportPresenter == null) throw new ArgumentNullException(nameof(tradingEquipmentMovementReportPresenter));

			InitializeComponent();

			CreateMenuItem(editMenuItem, producerPresenter, "Producers...");
			CreateMenuItem(editMenuItem, providerPresenter, "Providers...");
			CreateMenuItem(editMenuItem, equipmentTypePresenter, "Equipment Types...");
			CreateMenuItem(editMenuItem, tradingEquipmentModelPresenter, "Trading Equipment Models...");
			CreateMenuItem(editMenuItem, locationPresenter, "Locations...");

			CreateMenuItem(tradingEquipmentMenuItem, registerTradingEquipmentPresenter, "Register...");
			CreateMenuItem(tradingEquipmentMenuItem, moveTradingEquipmentPresenter, "Move...");

			CreateMenuItem(reportsMenuItem, tradingEquipmentReportPresenter, "Trading Equipment...");
			CreateMenuItem(reportsMenuItem, tradingEquipmentMovementReportPresenter, "Trading Equipment Movement...");
		}

		private static void CreateMenuItem(ToolStripMenuItem parentMenu, IPresenter presenter, string text)
		{
			var menuItem = new ToolStripMenuItem { Text = text };
			menuItem.Click += (sender, args) => presenter.OpenView();
			parentMenu.DropDownItems.Add(menuItem);
		}
	}
}