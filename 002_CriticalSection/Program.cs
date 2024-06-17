//Критическая секция (critical section)

//lock - это сокращенное использование System.Threading.Monitor.
//Monitor.Enter(this) - блокирует блок кода так, что его может использовать только текущий поток
//Все остальные потоки ждут пока текущий поток выполнит работу  и вызовет Monitor.Exit(this).
class MyClass
{
    //объект блокировки
    object block = new object();
    //поток
    public void Method()
    {
        int hash = Thread.CurrentThread.GetHashCode();

        //критическая секция
        Monitor.Enter(block);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Поток {hash} : шаг {i}");
            Thread.Sleep(100);
        }
        Console.WriteLine(new string('-', 20));

        Monitor.Exit(block);

    }
}
class Program
{
    static void Main()
    {
        MyClass instance = new MyClass();

        for (int i = 0; i < 3; i++)
        {
            new Thread(instance.Method).Start();
        }

        Thread.Sleep(500);
    }
}