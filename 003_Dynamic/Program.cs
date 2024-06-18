class Program
{
    //Динамические типы данных (Статические поля)

    dynamic variable = 1;
    static void Main()
    {
        dynamic instance = new Program();

        Console.WriteLine(instance.variable);
        instance.variable = "Hello world!!";

        Console.WriteLine(instance.variable);

        instance.variable = DateTime.Now;

        Console.WriteLine(instance.variable);
    }