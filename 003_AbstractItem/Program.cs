AbstractClassA instance = new ConcreteClass();
instance.OperationA();
//instance.OperationB(); нельзя тк произошел апкаст к AbstractClassA
abstract class AbstractClassA
{
    public abstract void OperationA();
}
abstract class AbstractClassB : AbstractClassA
{
    public abstract void OperationB();
}
class ConcreteClass : AbstractClassB
{
    public override void OperationA()
    {
        Console.WriteLine("OperationA");
    }

    public override void OperationB()
    {
        Console.WriteLine("OperationB");
    }
}