using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Commands;
using Shared.InfoObjects;
using Shared.Queries;

namespace Gui.Services
{
	public class ProducerService : BaseService, IProducerService
	{
		public Task<IEnumerable<ProducerInfo>> GetAllAsync()
		{
			return JsonServiceClient.GetAsync(new GetAllProducersQuery());
		}

		public Task<ProducerInfo> GetAsync(long id)
		{
			return JsonServiceClient.GetAsync(new GetProducerQuery { Id = id });
		}

		public Task<bool> GetIsReferencedAsync(long id)
		{
			return JsonServiceClient.GetAsync(new GetProducerIsReferencedQuery { Id = id });
		}

		public Task<ProducerInfo> AddAsync(ProducerInfo producer)
		{
			if (producer == null) throw new ArgumentNullException(nameof(producer));

			return JsonServiceClient.PostAsync(new AddProducerCommand { Producer = producer });
		}

		public Task UpdateAsync(ProducerInfo producer)
		{
			if (producer == null) throw new ArgumentNullException(nameof(producer));

			return JsonServiceClient.PutAsync(new UpdateProducerCommand
			{
				Id = producer.Id,
				Producer = producer
			});
		}

		public Task RemoveAsync(long id)
		{
			return JsonServiceClient.DeleteAsync(new RemoveProducerCommand { Id = id });
		}
	}
}