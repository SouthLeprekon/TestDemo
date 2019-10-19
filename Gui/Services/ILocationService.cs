using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.InfoObjects;

namespace Gui.Services
{
	public interface ILocationService
	{
		Task<IEnumerable<LocationInfo>> GetAllAsync();
		Task<LocationInfo> GetAsync(long id);
		Task<bool> GetIsReferencedAsync(long id);
		Task<LocationInfo> AddAsync(LocationInfo location);
		Task UpdateAsync(LocationInfo location);
		Task RemoveAsync(long id);
	}
}