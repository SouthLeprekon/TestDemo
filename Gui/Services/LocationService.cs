using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Commands;
using Shared.InfoObjects;
using Shared.Queries;

namespace Gui.Services
{
	public class LocationService : BaseService, ILocationService
	{
		public Task<IEnumerable<LocationInfo>> GetAllAsync()
		{
			return JsonServiceClient.GetAsync(new GetAllLocationsQuery());
		}

		public Task<LocationInfo> GetAsync(long id)
		{
			return JsonServiceClient.GetAsync(new GetLocationQuery { Id = id });
		}

		public Task<bool> GetIsReferencedAsync(long id)
		{
			return JsonServiceClient.GetAsync(new GetLocationIsReferencedQuery { Id = id });
		}

		public Task<LocationInfo> AddAsync(LocationInfo location)
		{
			if (location == null) throw new ArgumentNullException(nameof(location));

			return JsonServiceClient.PostAsync(new AddLocationCommand { Location = location });
		}

		public Task UpdateAsync(LocationInfo location)
		{
			if (location == null) throw new ArgumentNullException(nameof(location));

			return JsonServiceClient.PutAsync(new UpdateLocationCommand
			{
				Id = location.Id,
				Location = location
			});
		}

		public Task RemoveAsync(long id)
		{
			return JsonServiceClient.DeleteAsync(new RemoveLocationCommand { Id = id });
		}
	}
}