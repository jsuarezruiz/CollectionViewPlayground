using CollectionViewPlayground.ViewModels.Base;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewPlayground.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand BasicCommand => new Command(Basic);
        public ICommand CarouselCommand => new Command(Carousel);
        public ICommand HorizontalListCommand => new Command(HorizontalList);
        public ICommand GridViewCommand => new Command(GridView);
        public ICommand EmptyCommand => new Command(Empty);

        void Basic()
        {
            NavigationService.NavigateToAsync<BasicViewModel>();
        }

        void Carousel()
        {
            NavigationService.NavigateToAsync<CarouselViewModel>();
        }

        void HorizontalList()
        {
            NavigationService.NavigateToAsync<HorizontalListViewModel>();
        }

        void GridView()
        {
            NavigationService.NavigateToAsync<GridViewModel>();
        }

        void Empty()
        {
            NavigationService.NavigateToAsync<EmptyViewModel>();
        }
    }
}