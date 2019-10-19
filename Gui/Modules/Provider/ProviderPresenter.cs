using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Gui.Extensions;
using Gui.Services;
using Shared.InfoObjects;

namespace Gui.Modules.Provider
{
	public class ProviderPresenter : IProviderPresenter
	{
		private readonly IProviderView _view;
		private readonly IProviderService _providerService;

		public ProviderPresenter(IProviderView view, IProviderService providerService)
		{
			if (view == null) throw new ArgumentNullException(nameof(view));
			if (providerService == null) throw new ArgumentNullException(nameof(providerService));

			_view = view;
			_view.Observer = this;
			_providerService = providerService;
		}

		public async void OpenView()
		{
			var providers = await _providerService.GetAllAsync();
			_view.Providers = new BindingList<ProviderInfo>(providers.ToList());
			EnableOperations();
			_view.Open();
		}

		public void SelectedProviderChanged()
		{
			EnableOperations();
		}

		public void AddProviderRequested()
		{
			_view.RequestProviderProperties(new ProviderInfo());
		}

		public void EditProviderRequested()
		{
			_view.RequestProviderProperties(_view.SelectedProvider);
		}

		public async void RemoveProviderRequested()
		{
			if (!_view.RemoveProviderConfirmed) return;

			var provider = _view.SelectedProvider;

			if (await _providerService.GetIsReferencedAsync(provider.Id))
			{
				_view.ShowProviderIsReferencedWarning();
				return;
			}

			await _providerService.RemoveAsync(provider.Id);
			_view.Providers.Remove(provider);
		}

		public async void ProviderPropertiesAccepted(ProviderInfo provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_view.SelectedProvider = await SaveProviderAsync(provider);
		}

		private void EnableOperations()
		{
			var providerSelected = _view.SelectedProvider != null;
			_view.CanEditProvider = providerSelected;
			_view.CanRemoveProvider = providerSelected;
		}

		private async Task<ProviderInfo> SaveProviderAsync(ProviderInfo provider)
		{
			if (_view.Providers.All(x => x.Id != provider.Id))
			{
				provider = await _providerService.AddAsync(provider);
				_view.Providers.Add(provider);
			}
			else
			{
				await _providerService.UpdateAsync(provider);
				provider = await _providerService.GetAsync(provider.Id);
				_view.Providers.AddOrReplace(x => x.Id == provider.Id, provider);
			}

			return provider;
		}
	}
}