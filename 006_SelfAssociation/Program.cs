Factory factory = new Factory();
Product product = factory.FactoryMethod();

class Product
{
    public Product()
    {
        Console.WriteLine("New instance!");
    }
}
class Factory
{
    public Product FactoryMethod()
    {
        return new Product();
    }
}
