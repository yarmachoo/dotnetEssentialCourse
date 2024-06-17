class UserException : Exception
{
    public void Method()
    {
        Console.WriteLine("Мое исключение!");
    }
}
class Program
{
    static void Main()
    {
        try
        {
            throw new UserException();
        }
        catch (UserException ex)
        {
            ex.Method();
        }
    }
}