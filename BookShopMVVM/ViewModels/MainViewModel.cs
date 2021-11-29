using BookShopMVVM.Models;

namespace BookShopMVVM.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel(NavigationStore navigationStore)
        {
            NavigationStore = navigationStore;
        }

        public NavigationStore NavigationStore { get; set; }
    }
}