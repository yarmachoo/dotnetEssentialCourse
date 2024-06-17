using System.ComponentModel;

//При использовании абстрактных классов 
AbstractClass instacne = new ConcreteClass();
instacne.Method();
//Абстрактный класс
abstract class AbstractClass
{
    public abstract void Method();
}
//Конкректный класс
class ConcreteClass: AbstractClass
{
    public override void Method()
    {
        Console.WriteLine("Implementation!");
    }
}