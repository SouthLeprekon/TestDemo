using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Gui.Extensions;
using Gui.Services;
using Shared.InfoObjects;

namespace Gui.Modules.Producer
{
	public class ProducerPresenter : IProducerPresenter
	{
		private readonly IProducerView _view;
		private readonly IProducerService _producerService;

		public ProducerPresenter(IProducerView view, IProducerService producerService)
		{
			if (view == null) throw new ArgumentNullException(nameof(view));
			if (producerService == null) throw new ArgumentNullException(nameof(producerService));

			_view = view;
			_view.Observer = this;
			_producerService = producerService;
		}

		public async void OpenView()
		{
			var producers = await _producerService.GetAllAsync();
			_view.Producers = new BindingList<ProducerInfo>(producers.ToList());
			EnableOperations();
			_view.Open();
		}

		public void SelectedProducerChanged()
		{
			EnableOperations();
		}

		public void AddProducerRequested()
		{
			_view.RequestProducerProperties(new ProducerInfo());
		}

		public void EditProducerRequested()
		{
			_view.RequestProducerProperties(_view.SelectedProducer);
		}

		public async void RemoveProducerRequested()
		{
			if (!_view.RemoveProducerConfirmed) return;

			var producer = _view.SelectedProducer;

			if (await _producerService.GetIsReferencedAsync(producer.Id))
			{
				_view.ShowProducerIsReferencedWarning();
				return;
			}

			await _producerService.RemoveAsync(producer.Id);
			_view.Producers.Remove(producer);
		}

		public async void ProducerPropertiesAccepted(ProducerInfo producer)
		{
			if (producer == null) throw new ArgumentNullException(nameof(producer));

			_view.SelectedProducer = await SaveProducerAsync(producer);
		}

		private void EnableOperations()
		{
			var producerSelected = _view.SelectedProducer != null;
			_view.CanEditProducer = producerSelected;
			_view.CanRemoveProducer = producerSelected;
		}

		private async Task<ProducerInfo> SaveProducerAsync(ProducerInfo producer)
		{
			if (_view.Producers.All(x => x.Id != producer.Id))
			{
				producer = await _producerService.AddAsync(producer);
				_view.Producers.Add(producer);
			}
			else
			{
				await _producerService.UpdateAsync(producer);
				producer = await _producerService.GetAsync(producer.Id);
				_view.Producers.AddOrReplace(x => x.Id == producer.Id, producer);
			}

			return producer;
		}
	}
}