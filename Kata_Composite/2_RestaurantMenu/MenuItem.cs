namespace Kata_Composite._2
{
    public class MenuItem : MenuComponent
    {
        private string name;
        private decimal price;

        public MenuItem(string name, decimal price)
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
            Console.WriteLine($"Elemento: {name}, Precio: {price}");
        }
    }
}
