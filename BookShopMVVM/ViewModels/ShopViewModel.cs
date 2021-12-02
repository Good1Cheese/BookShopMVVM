using BookShopMVVM.Commands;
using BookShopMVVM.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

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

            AddProductToCart = new ActionCommand((obj) =>
            {
                CartProducts.Add((Product)obj);
            });

            RemoveProduct = new ActionCommand((obj) =>
            {
                CartProducts.Remove((Product)obj);
            });
        }

        public ShopViewModel()
        {
            
        }

        public ActionCommand AddProductToCart { get; set; }
        public ActionCommand RemoveProduct { get; set; }

        public List<Product> Products { get; set; }
        public ObservableCollection<Product> CartProducts { get; set; } = new ObservableCollection<Product>();
    }
}
