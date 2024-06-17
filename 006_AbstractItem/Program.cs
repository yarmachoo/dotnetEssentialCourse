AbstractClass instance = new ConcreteClass();
Console.WriteLine(new string('-', 50));

instance.AbstractMethod();
abstract class AbstractClass
{
    public AbstractClass()
    {
        Console.WriteLine("1 AbstractClass();");
        this.AbstractMethod();//Техника шаблонного метода
        Console.WriteLine("2 AbstractClass();");
    }
    public abstract void AbstractMethod();
}
class ConcreteClass : AbstractClass
{
    string s = "FIRST";
    public ConcreteClass()
    {
        Console.WriteLine("3 ConcreteClass();");
        s = "SECOND";
    }
    public override void AbstractMethod()
    {
        Console.WriteLine($"реализации метода AbstractMethod() в ConcreteClass {s}");
    }
}