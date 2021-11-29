using BookShopMVVM.Commands;
using BookShopMVVM.Models;

namespace BookShopMVVM.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigationCommand = new NavigationCommand(navigationStore, new ShopViewModel(navigationStore, this));
        }
    }
}
