using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.InfoObjects;

namespace Gui.Services
{
	public interface IProviderService
	{
		Task<IEnumerable<ProviderInfo>> GetAllAsync();
		Task<ProviderInfo> GetAsync(long id);
		Task<bool> GetIsReferencedAsync(long id);
		Task<ProviderInfo> AddAsync(ProviderInfo provider);
		Task UpdateAsync(ProviderInfo provider);
		Task RemoveAsync(long id);
	}
}