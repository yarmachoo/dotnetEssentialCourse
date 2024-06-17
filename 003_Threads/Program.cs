using System.Threading;

class Program
{
    static void WriteSecond()
    {
        //Thread.CurrentThread - возвращает ссылку на экземпляр текущего потока
        Thread thread = Thread.CurrentThread;

        thread.Name = "Secondary";

        Console.WriteLine($"Id потока {thread.Name} : {thread.GetHashCode()}");

        for (int i = 0; i< 10; i++)
        {
            Console.WriteLine(new string(' ', 15) + thread.Name + " " + i);
            Thread.Sleep(1000);
        }
    }
    static void Main()
    {
        Thread primaryThread = Thread.CurrentThread;


        primaryThread.Name = "Primary";
        Console.WriteLine($"Id потока {primaryThread.Name} : {primaryThread.GetHashCode()}");

        Thread secondarythread = new Thread(WriteSecond);
        secondarythread.Start();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine( primaryThread.Name + " " + i);
            Thread.Sleep(1500);
        }
    }
}