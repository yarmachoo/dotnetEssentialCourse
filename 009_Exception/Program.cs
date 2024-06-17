class Program
{
    static void Main()
    {
        try
        {
            throw new Exception();
        }
        catch(Exception ex)
        {
            throw new Exception();

            //или так:
            while(true) { Console.WriteLine("catch"); }
        }
        finally
        {
            //Finally не сработает
            Console.WriteLine("finally");
        }
    }
}