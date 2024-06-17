
ConcreteClass concreteClass = new ConcreteClass();
concreteClass.Method();

IInterface1 instance1 = concreteClass as IInterface1;
instance1.Method();


interface IInterface1
{
    void Method();
}
abstract class AbstractClass : IInterface1
{
    public abstract void Method();
}

class ConcreteClass : AbstractClass
{
    public override void Method()
    {
        Console.WriteLine("ConcreteClass.Method();");
    }
}

