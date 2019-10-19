using System;
using Domain;
using Shared.InfoObjects;

namespace WebService.Extensions
{
	public static class ProducerExtensions
	{
		public static ProducerInfo ToInfo(this Producer producer)
		{
			if (producer == null) throw new ArgumentNullException(nameof(producer));

			return new ProducerInfo
			{
				Id = producer.Id,
				Name = producer.Name,
				Address = producer.Address
			};
		}

		public static Producer FromInfo(this ProducerInfo producer)
		{
			if (producer == null) throw new ArgumentNullException(nameof(producer));

			return new Producer
			{
				Id = producer.Id,
				Name = producer.Name,
				Address = producer.Address
			};
		}
	}
}