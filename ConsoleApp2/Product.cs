namespace ConsoleApp2;

public abstract class Product
{
    public int Price { get; set; }
    public string Name { get; set; }
    public abstract void GetInfo();
}