using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Commands;
using Shared.InfoObjects;
using Shared.Queries;

namespace Gui.Services
{
	public class EquipmentTypeService : BaseService, IEquipmentTypeService
	{
		public Task<IEnumerable<EquipmentTypeInfo>> GetAllAsync()
		{
			return JsonServiceClient.GetAsync(new GetAllEquipmentTypesQuery());
		}

		public Task<EquipmentTypeInfo> GetAsync(long id)
		{
			return JsonServiceClient.GetAsync(new GetEquipmentTypeQuery { Id = id });
		}

		public Task<bool> GetIsReferencedAsync(long id)
		{
			return JsonServiceClient.GetAsync(new GetEquipmentTypeIsReferencedQuery { Id = id });
		}

		public Task<EquipmentTypeInfo> AddAsync(EquipmentTypeInfo equipmentType)
		{
			if (equipmentType == null) throw new ArgumentNullException(nameof(equipmentType));

			return JsonServiceClient.PostAsync(new AddEquipmentTypeCommand { EquipmentType = equipmentType });
		}

		public Task UpdateAsync(EquipmentTypeInfo equipmentType)
		{
			if (equipmentType == null) throw new ArgumentNullException(nameof(equipmentType));

			return JsonServiceClient.PutAsync(new UpdateEquipmentTypeCommand
			{
				Id = equipmentType.Id,
				EquipmentType = equipmentType
			});
		}

		public Task RemoveAsync(long id)
		{
			return JsonServiceClient.DeleteAsync(new RemoveEquipmentTypeCommand { Id = id });
		}
	}
}