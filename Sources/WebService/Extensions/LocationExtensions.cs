using System;
using Domain;
using Shared.InfoObjects;

namespace WebService.Extensions
{
	public static class LocationExtensions
	{
		public static LocationInfo ToInfo(this Location location)
		{
			if (location == null) throw new ArgumentNullException(nameof(location));

			return new LocationInfo
			{
				Id = location.Id,
				Name = location.Name,
				Address = location.Address
			};
		}

		public static Location FromInfo(this LocationInfo location)
		{
			if (location == null) throw new ArgumentNullException(nameof(location));

			return new Location
			{
				Id = location.Id,
				Name = location.Name,
				Address = location.Address
			};
		}
	}
}