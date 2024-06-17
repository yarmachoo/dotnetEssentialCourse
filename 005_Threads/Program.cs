//Потоки и асинъронные методы.

class Program
{
    static void Main()
    {
        int counter = 0;

        Thread thread = new Thread(delegate () { Console.WriteLine("1. Counter = {0}", ++counter); });
        thread.Start();

        Thread.Sleep(100);
        Console.WriteLine("2. Counter  = {0}", counter);

        thread = new Thread((object arg) => { Console.WriteLine("2. Counter  = {0}", (int)arg); });
        thread.Start(counter);
    }
}