
ConcreteClass concreteClass = new ConcreteClass();
//concreteClass.Method();
//concreteClass.Method();

IInterface1 instance1 = concreteClass as IInterface1;
instance1.Method();

IInterface2 instance2 = concreteClass as IInterface2;
instance2.Method();

interface IInterface1
//узкий интерфейс
{
    void Method();
}
interface IInterface2 : IInterface1
//широкий интерфейс
{
    //без new ошибки не будет, но будет предупреждение компиллятора
    new void Method();
}

class ConcreteClass : IInterface2
{
    void IInterface1.Method()
    {
        Console.WriteLine("IInterface1.Method1()");
    }

    void IInterface2.Method()
    {
        Console.WriteLine("IInterface2.Method2()");
    }
}
