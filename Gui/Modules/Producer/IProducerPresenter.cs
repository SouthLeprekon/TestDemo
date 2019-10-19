using Shared.InfoObjects;

namespace Gui.Modules.Producer
{
	public interface IProducerPresenter : IPresenter
	{
		void SelectedProducerChanged();
		void AddProducerRequested();
		void EditProducerRequested();
		void RemoveProducerRequested();
		void ProducerPropertiesAccepted(ProducerInfo producer);
	}
}