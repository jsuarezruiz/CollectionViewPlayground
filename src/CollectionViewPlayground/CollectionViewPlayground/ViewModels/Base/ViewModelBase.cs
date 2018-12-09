using CollectionViewPlayground.Services;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewPlayground.ViewModels.Base
{
    public class ViewModelBase : BindableObject
    {
        private bool _isBusy;

        protected readonly INavigationService NavigationService;
        protected readonly IMonkeyService MonkeyService;

        public ViewModelBase()
        {
            NavigationService = Locator.Instance.Resolve<INavigationService>();
            MonkeyService = Locator.Instance.Resolve<IMonkeyService>();
        }

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}