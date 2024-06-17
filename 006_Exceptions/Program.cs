int a = 1, n = 2;

try
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("попытка деления на ноль!");
    a = a / (2 - n);
}
catch(Exception e)
{
    Console.ForegroundColor= ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("обработка исключений");
    Console.WriteLine(e.Message);
}
finally
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.BackgroundColor = ConsoleColor.Black;
}
Console.WriteLine("Press any key.");