Exception ex = new Exception("Мое исключение!"); 
try 
{
    throw ex; 
}
catch(Exception e)
{
    Console.WriteLine("Обработка исключений");
    Console.WriteLine(e.Message);
}