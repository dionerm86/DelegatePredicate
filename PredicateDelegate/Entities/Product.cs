
namespace PredicateDelegate.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Product: " + Name + "\nPrice: " + Price.ToString("F2");
        }
    }
}
