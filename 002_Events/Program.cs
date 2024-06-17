public delegate void EventDelegate();

public class MyClass()
{
    EventDelegate myEvent = null;
    //Реализация методов доступа add и remove для события
    public event EventDelegate MyEvent
    {
        add { myEvent += value; }
        remove { myEvent -= value; }
    }
    public void InvokeEvent()
    {
        myEvent.Invoke();
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
        MyClass instance = new MyClass();

        //Техника предположения делегата
        instance.MyEvent += Handler1;
        instance.MyEvent += Handler2;

        instance.InvokeEvent();

    }
}
