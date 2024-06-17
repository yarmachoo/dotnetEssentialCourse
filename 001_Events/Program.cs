




public delegate void Eventdelegate();
public class MyClass
{
    public event Eventdelegate MyEvent = null;
    public void InvokeEvent()
    {
        MyEvent.Invoke();
    }
}
public class Program
{
    static private void Handler1()
    {
        Console.WriteLine("Обработчик события 1");
    }
    static private void Handler2()
    {
        Console.WriteLine("Обработчик события 2");
    }
    static void Main()
    {
        MyClass instance = new MyClass();

        //Предположение делегатов
        instance.MyEvent += new Eventdelegate(Handler1);
        instance.MyEvent += Handler2;

        instance.InvokeEvent();
        Console.WriteLine(new string('-', 50));

        //instance.MyEvent.Invoke(); НЕЛЬЗЯ извне вызывать событие!!!
        instance.MyEvent -= new Eventdelegate(Handler2);
        instance.InvokeEvent();
    }
}