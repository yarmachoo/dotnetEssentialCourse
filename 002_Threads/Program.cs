class Program
{
    static void WriteSecond()
    {
        //CLR назначает каждому потоку свой стек и методы имеют свои собственные локальные переменные.
        //Отдельный экземпляр переменной counter создается в стеке каждого протока,
        //Поэтому для каждого потока выводятся свои значения counter - 0, 1, 2...
        int counter = 0;
        while (counter < 10)
        {
            Thread.Sleep(500);
            Console.WriteLine("Thread id {0}, counter id {1}", Thread.CurrentThread.GetHashCode(), counter);
            counter++;
        }
    }
    static void Main()
    {
        //Раота вторичного потока (предположение делегата)
        Thread thread = new Thread(WriteSecond);
        thread.Start();


        //Работа первичного потока
        WriteSecond();
    }
}