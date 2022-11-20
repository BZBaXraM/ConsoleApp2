namespace ConsoleApp2;

public class Drinks : Product
{
    public Drinks(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"product name {Name}. Price - {Price}");
    }
}