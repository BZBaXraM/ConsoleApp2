namespace ConsoleApp2;

public static class Program
{
    public static void Main()
    {
        IProductCreator creator = new CreateDrink();
        Product product = creator.Create("cola", 2);
        product.GetInfo();
    }
}