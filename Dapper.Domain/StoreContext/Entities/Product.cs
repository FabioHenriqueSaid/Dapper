namespace Dapper.Domain.StoreContext
{
    public class Product
    {
        public Product(
            string title, 
            string description, 
            string image, 
            decimal price,
            decimal quantity)
        {
            Titlte = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantity;
        }
        public string Titlte { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal QuantityOnHand { get; set; }
    }
}