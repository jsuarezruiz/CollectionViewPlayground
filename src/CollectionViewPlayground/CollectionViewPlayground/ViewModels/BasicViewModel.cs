using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CollectionViewPlayground.Models;
using CollectionViewPlayground.ViewModels.Base;

namespace CollectionViewPlayground.ViewModels
{
    public class BasicViewModel : ViewModelBase
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