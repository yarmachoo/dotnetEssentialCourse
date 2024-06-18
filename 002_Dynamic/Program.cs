class Program
{
    //Динамические типы данных (Статические поля)

    static dynamic variable = 1;
    static void Main() { 

        Console.WriteLine(variable);
        variable = "Hello world!!";

        Console.WriteLine(variable);

        variable = DateTime.Now;

        Console.WriteLine(variable);
    }