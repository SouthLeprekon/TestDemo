using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Gui.Extensions;
using Gui.Services;
using Shared.InfoObjects;

namespace Gui.Modules.Location
{
	public class LocationPresenter : ILocationPresenter
	{
		private readonly ILocationView _view;
		private readonly ILocationService _locationService;

		public LocationPresenter(ILocationView view, ILocationService locationService)
		{
			if (view == null) throw new ArgumentNullException(nameof(view));
			if (locationService == null) throw new ArgumentNullException(nameof(locationService));

			_view = view;
			_view.Observer = this;
			_locationService = locationService;
		}

		public async void OpenView()
		{
			var locations = await _locationService.GetAllAsync();
			_view.Locations = new BindingList<LocationInfo>(locations.ToList());
			EnableOperations();
			_view.Open();
		}

		public void SelectedLocationChanged()
		{
			EnableOperations();
		}

		public void AddLocationRequested()
		{
			_view.RequestLocationProperties(new LocationInfo());
		}

		public void EditLocationRequested()
		{
			_view.RequestLocationProperties(_view.SelectedLocation);
		}

		public async void RemoveLocationRequested()
		{
			if (!_view.RemoveLocationConfirmed) return;

			var location = _view.SelectedLocation;

			if (await _locationService.GetIsReferencedAsync(location.Id))
			{
				_view.ShowLocationIsReferencedWarning();
				return;
			}

			await _locationService.RemoveAsync(location.Id);
			_view.Locations.Remove(location);
		}

		public async void LocationPropertiesAccepted(LocationInfo location)
		{
			if (location == null) throw new ArgumentNullException(nameof(location));

			_view.SelectedLocation = await SaveLocationAsync(location);
		}

		private void EnableOperations()
		{
			var locationSelected = _view.SelectedLocation != null;
			_view.CanEditLocation = locationSelected;
			_view.CanRemoveLocation = locationSelected;
		}

		private async Task<LocationInfo> SaveLocationAsync(LocationInfo location)
		{
			if (_view.Locations.All(x => x.Id != location.Id))
			{
				location = await _locationService.AddAsync(location);
				_view.Locations.Add(location);
			}
			else
			{
				await _locationService.UpdateAsync(location);
				location = await _locationService.GetAsync(location.Id);
				_view.Locations.AddOrReplace(x => x.Id == location.Id, location);
			}

			return location;
		}
	}
}