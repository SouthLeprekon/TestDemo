using Shared.InfoObjects;

namespace Gui.Modules.Location
{
	public interface ILocationPresenter : IPresenter
	{
		void SelectedLocationChanged();
		void AddLocationRequested();
		void EditLocationRequested();
		void RemoveLocationRequested();
		void LocationPropertiesAccepted(LocationInfo location);
	}
}