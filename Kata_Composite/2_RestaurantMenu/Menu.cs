namespace Kata_Composite._2
{
    public class Menu : MenuComponent
    {
        private string name;
        private List<MenuComponent> items = new List<MenuComponent>();

        public Menu(string name)
        {
            this.name = name;
        }

        public void Add(MenuComponent component)
        {
            items.Add(component);
        }

        public decimal GetPrice()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.GetPrice();
            }
            return total;
        }

        public void ShowDetails()
        {
            foreach (var item in items)
            {
                item.ShowDetails();
            }
            Console.WriteLine($"Menú: {name}, Precio Total: ${GetPrice()}");
        }
    }
}
