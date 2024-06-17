class Program
{
    //Вторичный поток
    static void WriteSecond()
    {
        while(true)
        {
            Console.WriteLine(new string(' ', 10)+ "Secondary");
        }
    }
    //Первичный поток
    static void Main()
    {
        //делегат
        ThreadStart writeSecond = new ThreadStart(WriteSecond);
        //Объектно ориентированное представление потока
        Thread thread = new Thread(writeSecond);

        thread.Start();

        while (true)
        {
            Console.WriteLine("Primary");
        }
    }
}
