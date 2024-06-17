
DerivedClass concreteClass = new DerivedClass();
concreteClass.Method();

Interface instance1 = concreteClass as Interface;
instance1.Method();


interface Interface
{
    void Method();
}
class BaseClass : Interface
{
    public void Method()
    {
        Console.WriteLine("BaseClass.Method();");
    }
}

class DerivedClass : BaseClass, Interface
{
    //Реализация интерфейса не обязательна, т. к. 
    //сигнатуры методов в классе и интерфейсе совпадают.
}

