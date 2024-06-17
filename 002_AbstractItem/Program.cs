AbstractClass instance = new ConcreteClassB();
instance.Method();
instance.Operation();
class ConcreteClassA
{
    public void Operation()
    {
        Console.WriteLine("ConcreteClassA.Operation");
    }
}

abstract class AbstractClass: ConcreteClassA
{
    public abstract void Method();
}

class ConcreteClassB: AbstractClass
{
    public override void Method()
    {
        Console.WriteLine("ConcreteClassB.Method ");
    }
}