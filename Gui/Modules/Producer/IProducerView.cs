using System.ComponentModel;
using Shared.InfoObjects;

namespace Gui.Modules.Producer
{
	public interface IProducerView : IView
	{
		IProducerPresenter Observer { set; }
		BindingList<ProducerInfo> Producers { get; set; }
		ProducerInfo SelectedProducer { get; set; }
		bool CanEditProducer { set; }
		bool CanRemoveProducer { set; }
		bool RemoveProducerConfirmed { get; }
		void ShowProducerIsReferencedWarning();
		void RequestProducerProperties(ProducerInfo producer);
	}
}