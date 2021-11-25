namespace BookShopMVVM.Models
{
    public class Product
    {
        public Product(string title, string description, int price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
