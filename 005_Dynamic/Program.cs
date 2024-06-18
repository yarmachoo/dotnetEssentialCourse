class Program
{
    //Динамические типы данных (Динамические типы аргументов и возвращаемых значений методов)

    static dynamic Method(dynamic argument)
    {
        return "Hello " + argument;
    }
    static void Main()
    {
        string @string = Method("friend!");

        Console.WriteLine(@string);
    }
}
