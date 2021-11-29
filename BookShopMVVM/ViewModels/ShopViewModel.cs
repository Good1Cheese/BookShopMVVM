using BookShopMVVM.Commands;
using BookShopMVVM.Models;
using System.Collections.Generic;

namespace BookShopMVVM.ViewModels
{
    public class ShopViewModel : ViewModelBase
    {
        public ShopViewModel(NavigationStore navigationStore, HomeViewModel homeViewModel)
        {
            NavigationCommand = new NavigationCommand(navigationStore, homeViewModel);

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

        public ShopViewModel()
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

        public List<Product> Products { get; set; }
    }
}
