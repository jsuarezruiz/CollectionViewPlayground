using System.Collections.ObjectModel;
using CollectionViewPlayground.Models;

namespace CollectionViewPlayground.Services
{
    public interface IMonkeyService
    {
        ObservableCollection<Monkey> GetMonkeys();
    }
}
