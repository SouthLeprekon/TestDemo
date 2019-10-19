using System;
using Domain;
using Shared.InfoObjects;

namespace WebService.Extensions
{
	public static class ProviderExtensions
	{
		public static ProviderInfo ToInfo(this Provider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			return new ProviderInfo
			{
				Id = provider.Id,
				Name = provider.Name,
				Address = provider.Address
			};
		}

		public static Provider FromInfo(this ProviderInfo provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			return new Provider
			{
				Id = provider.Id,
				Name = provider.Name,
				Address = provider.Address
			};
		}
	}
}