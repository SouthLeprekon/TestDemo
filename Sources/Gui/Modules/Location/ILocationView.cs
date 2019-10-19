using System.ComponentModel;
using Shared.InfoObjects;

namespace Gui.Modules.Location
{
	public interface ILocationView : IView
	{
		ILocationPresenter Observer { set; }
		BindingList<LocationInfo> Locations { get; set; }
		LocationInfo SelectedLocation { get; set; }
		bool CanEditLocation { set; }
		bool CanRemoveLocation { set; }
		bool RemoveLocationConfirmed { get; }
		void RequestLocationProperties(LocationInfo location);
		void ShowLocationIsReferencedWarning();
	}
}