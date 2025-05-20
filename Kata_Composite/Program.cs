using Kata_Composite._2;
using Kata_Composite._4;

class Program
{
    static void Main(string[] args)
    {
        #region Kata 2: RestaurantMenu

        Console.WriteLine("Kata 2: RestaurantMenu");

        MenuItem pizza = new MenuItem("Pizza", 10);
        MenuItem ensalada = new MenuItem("Ensalada", 5);

        Menu almuerzo = new Menu("Almuerzo");
        almuerzo.Add(pizza);
        almuerzo.Add(ensalada);

        almuerzo.ShowDetails();

        #endregion

        Console.WriteLine("\n" + "=====================================" + "\n");

        #region Kata 4: ProductSystem

        Console.WriteLine("Kata 4: ProductSystem");

        Product laptop = new Product("Laptop", 1000);
        Product mouse = new Product("Mouse", 50);

        ProductPackage oficina = new ProductPackage("Oficina");
        oficina.Add(laptop);
        oficina.Add(mouse);

        oficina.ShowDetails();

        #endregion
    }
}
