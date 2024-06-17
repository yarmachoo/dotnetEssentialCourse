
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
    //реализация абстрактного метода из интерфейса
    //в абстрактном классе НЕ обязательна!!!
    public void Method()
    {
        Console.WriteLine("Abstract.Method()");
    }
}

class ConcreteClass :AbstractClass
{ }

