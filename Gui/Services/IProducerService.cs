using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.InfoObjects;

namespace Gui.Services
{
	public interface IProducerService
	{
		Task<IEnumerable<ProducerInfo>> GetAllAsync();
		Task<ProducerInfo> GetAsync(long id);
		Task<bool> GetIsReferencedAsync(long id);
		Task<ProducerInfo> AddAsync(ProducerInfo producer);
		Task UpdateAsync(ProducerInfo producer);
		Task RemoveAsync(long id);
	}
}