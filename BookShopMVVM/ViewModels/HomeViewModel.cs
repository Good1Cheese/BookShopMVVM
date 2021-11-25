using BookShopMVVM.Commands;
using BookShopMVVM.Models;
using System.Collections.Generic;

namespace BookShopMVVM.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public List<Product> Products { get; set; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigationCommand = new NavigationCommand(navigationStore, new ShopViewModel(navigationStore, this));
        }

        public HomeViewModel()
        {
            Products = new List<Product>()
            {
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231),
                new Product("Product Name", "Nullam posuere turpis vel lacinia luctus. Donec in efficitur neque.", 231)
            };
        }
    }
}
