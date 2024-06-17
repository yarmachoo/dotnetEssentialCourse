
ConcreteClass concreteClass = new ConcreteClass();
concreteClass.Method();
concreteClass.Method();

IInterface1 instance1 = concreteClass as IInterface1;
instance1.Method();

IInterface2 instance2 = concreteClass as IInterface2;
instance2.Method();

interface IInterface1
//узкий интерфейс
{
    void Method();
}
interface IInterface2
//широкий интерфейс
{
    void Method();
}

class ConcreteClass : IInterface2, IInterface1
{
    //Объединение реализации одноименных абстрактных членов
    //public можно использовать!
    public void Method()
    {
        Console.WriteLine("IInterface.Method()");
    }
}
