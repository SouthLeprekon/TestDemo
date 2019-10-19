using System;
using System.Collections.Generic;
using ServiceStack;
using Shared.InfoObjects;

namespace Shared.Queries
{
	[Route("tradingEquipment/{minPurchaseDate}")]
	public class GetTradingEquipmentQuery : IReturn<IEnumerable<TradingEquipmentInfo>>
	{
		public DateTime MinPurchaseDate { get; set; }
	}
}