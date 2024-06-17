public delegate void EventDelegate();
interface IInterface
{
    event EventDelegate MyEvent; //абстрактное событие.
    void InvokeEvent();
}
public class BaseClass : IInterface
{
    public virtual event EventDelegate MyEvent = null;
    public virtual void InvokeEvent()
    {
        MyEvent.Invoke();
    }
}

public class DerivedClass : BaseClass
{
    public override event EventDelegate MyEvent = null;
    public override void InvokeEvent()
    {
        MyEvent.Invoke();
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