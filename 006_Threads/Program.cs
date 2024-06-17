class Program
{
    static void WriteSecond()
    {
        while (true)
        {
            Console.WriteLine(new string(' ', 15)+ "Secondary");
            Thread.Sleep(500);
        }

    }
    static void Main()
    {
        ThreadStart writeSecond = new ThreadStart(WriteSecond);
        Thread thread = new Thread(writeSecond);
        thread.Start();

        for(int i = 0;  i < 10; i++)
        {
            Console.WriteLine("Primary");
            Thread.Sleep(500);
        }

        //Завершить работу вторичного потока
        //по умолчанию  = false  - ожидание окончания потока
        thread.IsBackground = true;
    }
}
