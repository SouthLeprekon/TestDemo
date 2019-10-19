using Shared.InfoObjects;

namespace Gui.Modules.Provider
{
	public interface IProviderPresenter : IPresenter
	{
		void SelectedProviderChanged();
		void AddProviderRequested();
		void EditProviderRequested();
		void RemoveProviderRequested();
		void ProviderPropertiesAccepted(ProviderInfo provider);
	}
}