
ConcreteClass concreteClass = new ConcreteClass();
concreteClass.Method1();
concreteClass.Method2();

IInterface1 instance1 = concreteClass as IInterface1;
instance1.Method1();

IInterface2 instance2 = concreteClass as IInterface2;
instance2.Method1();
instance2.Method2();

interface IInterface1
    //узкий интерфейс
{
    void Method1();
}
interface IInterface2: IInterface1
    //широкий интерфейс
{
    void Method2();
}

class ConcreteClass : IInterface2
{
    public void Method1()
    {
        Console.WriteLine("IInterface1.Method1()");
    }

    public void Method2()
    {
        Console.WriteLine("IInterface2.Method2()");
    }
}
