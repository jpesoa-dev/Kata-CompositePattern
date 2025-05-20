namespace Kata_Composite._4
{
    public class Product : ProductComponent
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Producto: {name}, Precio: {price}");
        }
    }
}
