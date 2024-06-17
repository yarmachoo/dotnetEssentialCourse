int a = 1, n = 2;
try
{
    a = a / (2 - n);
    Console.WriteLine(a);
}
catch (Exception e)
{
    Console.WriteLine("Обработка исключений");
    Console.WriteLine(e.Message);
    Console.WriteLine(e.GetType());
}
