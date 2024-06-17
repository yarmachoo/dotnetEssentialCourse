//Критическая секция (critical section)

//lock - блокирует блок кода так, что в каждый отдельный момент времени,
//этот блок кода сможет использовать только один поток. Все остальные
//потоки ждут, пока текущий поток закончит работу
class MyClass
{
    //объект блокировки
    object block = new object();
    //поток
    public void Method()
    {
        int hash = Thread.CurrentThread.GetHashCode();

        //критическая секция
        lock(block)
        {
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine($"Поток {hash} : шаг {i}");
                Thread.Sleep(100);
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
class Program
{
    static void Main()
    {
        MyClass instance = new MyClass();

        for(int i = 0; i<3; i++)
        {
            new Thread(instance.Method).Start();
        }

        Thread.Sleep(500);
    }
}