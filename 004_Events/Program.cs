public delegate void EventDelegate();
interface IInterface
{
    event EventDelegate MyEvent; //абстрактное событие.
}
public class BaseClass: IInterface
{
    EventDelegate myEvent = null;
    public virtual event EventDelegate MyEvent
    {
        add { myEvent += value; }
        remove { myEvent -= value; }
    }
    public void InvokeEvent()
    {
        myEvent.Invoke();
    }
}

public class DerivedClass : BaseClass
{
    public override event EventDelegate MyEvent
    {
        add
        {
            base.MyEvent += value;
            Console.WriteLine("К событию базового класса был прикреплен обработчик - {0}", value.Method.Name);
        }
        remove
        {
            base.MyEvent -= value;
            Console.WriteLine("От события базового класса был откреплен обработчик - {0}", value.Method.Name);
        }
    }
}

class Program
{
    static private void Handler1()
    {
        Console.WriteLine("Обработчик события 1!");
    }
    static private void Handler2()
    {
        Console.WriteLine("Обработчик события 2!");
    }
    static void Main()
    {
        DerivedClass instance = new DerivedClass();

        //Техника предположения делегата
        instance.MyEvent += Handler1;
        instance.MyEvent += Handler2;

        instance.InvokeEvent();

        Console.WriteLine(new string('-', 50));

        instance.MyEvent -= Handler1;
        instance.InvokeEvent();
    }
}