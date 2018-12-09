using CollectionViewPlayground.Models;
using CollectionViewPlayground.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CollectionViewPlayground.ViewModels
{
    public class EmptyViewModel : ViewModelBase
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
            return base.InitializeAsync(navigationData);
        }
    }
}