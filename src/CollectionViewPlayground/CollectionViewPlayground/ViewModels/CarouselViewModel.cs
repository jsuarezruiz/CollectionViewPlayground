using CollectionViewPlayground.Models;
using CollectionViewPlayground.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CollectionViewPlayground.ViewModels
{
    public class CarouselViewModel : ViewModelBase
    {
        ObservableCollection<Monkey> _monkeys;

        public ObservableCollection<Monkey> Monkeys
        {
            get { return _monkeys; }
            set
            {
                _monkeys = value;
                OnPropertyChanged();
            }
        }

        public override Task InitializeAsync(object navigationData)
        {
            Monkeys = MonkeyService.GetMonkeys();

            return base.InitializeAsync(navigationData);
        }
    }
}