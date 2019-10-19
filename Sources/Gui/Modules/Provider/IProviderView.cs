using System.ComponentModel;
using Shared.InfoObjects;

namespace Gui.Modules.Provider
{
	public interface IProviderView : IView
	{
		IProviderPresenter Observer { set; }
		BindingList<ProviderInfo> Providers { get; set; }
		ProviderInfo SelectedProvider { get; set; }
		bool CanEditProvider { set; }
		bool CanRemoveProvider { set; }
		bool RemoveProviderConfirmed { get; }
		void RequestProviderProperties(ProviderInfo provider);
		void ShowProviderIsReferencedWarning();
	}
}