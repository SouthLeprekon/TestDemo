using System.Configuration;
using ServiceStack;

namespace Gui.Services
{
	public abstract class BaseService
	{
		protected BaseService()
		{
			var webServiceUrl = ConfigurationManager.AppSettings["webServiceUrl"];
			JsonServiceClient = new JsonServiceClient(webServiceUrl);
		}

		protected JsonServiceClient JsonServiceClient { get; }
	}
}