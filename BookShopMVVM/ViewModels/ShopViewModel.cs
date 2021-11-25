using BookShopMVVM.Commands;
using BookShopMVVM.Models;

namespace BookShopMVVM.ViewModels
{
    public class ShopViewModel : ViewModelBase
    {
        public ShopViewModel(NavigationStore navigationStore, HomeViewModel homeViewModel)
        {
            NavigationCommand = new NavigationCommand(navigationStore, homeViewModel);
        }
    }
}
