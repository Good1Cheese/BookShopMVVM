using BookShopMVVM.Models;
using BookShopMVVM.ViewModels;
using BookShopMVVM.Views;
using System.Windows;

namespace BookShopMVVM
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            NavigationStore navigationStore = new();
            HomeViewModel homeViewModel = new HomeViewModel(navigationStore);
            navigationStore.CurrentViewModel = homeViewModel;

            MainWindow mainWindow = new()
            {
                DataContext = new MainViewModel(navigationStore)
            };

            mainWindow.Show();
        }
    }
}
