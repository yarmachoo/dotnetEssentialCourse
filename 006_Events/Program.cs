public delegate void EventDelegate();
public class MyClass
{
    public event EventDelegate MyEvent = null;
    public void InvokeDelegate()
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
        MyClass instance = new MyClass();

        instance.MyEvent += Handler1;
        instance.MyEvent += Handler2;
        instance.MyEvent += delegate { Console.WriteLine("Анонимный метод "); };


        instance.InvokeDelegate();

        //не сработает!
        instance.MyEvent -= delegate { Console.WriteLine("Анонимный метод "); };

        instance.InvokeDelegate();
    }
}