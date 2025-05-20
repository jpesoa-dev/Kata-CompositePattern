namespace Kata_Composite._4
{
    public class ProductPackage : ProductComponent
    {
        private string name;
        private List<ProductComponent> components = new List<ProductComponent>();

        public ProductPackage(string name)
        {
            this.name = name;
        }

        public void Add(ProductComponent component)
        {
            components.Add(component);
        }

        public decimal GetPrice()
        {
            decimal total = 0;
            foreach (var component in components)
            {
                total += component.GetPrice();
            }
            return total;
        }

        public void ShowDetails()
        {
            foreach (var component in components)
            {
                component.ShowDetails();
            }
            Console.WriteLine($"Paquete: {name}, Precio Total: ${GetPrice()}");
        }
    }
}
