using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Commands;
using Shared.InfoObjects;
using Shared.Queries;

namespace Gui.Services
{
	public class ProviderService : BaseService, IProviderService
	{
		public Task<IEnumerable<ProviderInfo>> GetAllAsync()
		{
			return JsonServiceClient.GetAsync(new GetAllProvidersQuery());
		}

		public Task<ProviderInfo> GetAsync(long id)
		{
			return JsonServiceClient.GetAsync(new GetProviderQuery { Id = id });
		}

		public Task<bool> GetIsReferencedAsync(long id)
		{
			return JsonServiceClient.GetAsync(new GetProviderIsReferencedQuery { Id = id });
		}

		public Task<ProviderInfo> AddAsync(ProviderInfo provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			return JsonServiceClient.PostAsync(new AddProviderCommand { Provider = provider });
		}

		public Task UpdateAsync(ProviderInfo provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			return JsonServiceClient.PutAsync(new UpdateProviderCommand
			{
				Id = provider.Id,
				Provider = provider
			});
		}

		public Task RemoveAsync(long id)
		{
			return JsonServiceClient.DeleteAsync(new RemoveProviderCommand { Id = id });
		}
	}
}