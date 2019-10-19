using System;
using Domain;
using Shared.InfoObjects;

namespace WebService.Extensions
{
	public static class EquipmentTypeExtensions
	{
		public static EquipmentTypeInfo ToInfo(this EquipmentType equipmentType)
		{
			if (equipmentType == null) throw new ArgumentNullException(nameof(equipmentType));

			return new EquipmentTypeInfo
			{
				Id = equipmentType.Id,
				Name = equipmentType.Name
			};
		}

		public static EquipmentType FromInfo(this EquipmentTypeInfo equipmentType)
		{
			if (equipmentType == null) throw new ArgumentNullException(nameof(equipmentType));

			return new EquipmentType
			{
				Id = equipmentType.Id,
				Name = equipmentType.Name
			};
		}
	}
}