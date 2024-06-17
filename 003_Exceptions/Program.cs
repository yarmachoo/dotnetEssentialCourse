try
{
    throw new Exception("Мое исключение!");
}
catch (Exception e)
{
    Console.WriteLine("Обработка исключений");
    Console.WriteLine(e.Message);
}