namespace ConsoleApp2;

public class CreateDrink : IProductCreator
{
    public Product Create(string name, int price) => new Drinks(name, price);
}