class Program
{
    public static void Method()
    {
        int[] arr = new int[10];
        Console.WriteLine(arr);
        Method();
    }
    public static void Main()
    {
        try
        {
            //Method();
            Action m = null;
            m = () =>
            {
                Console.WriteLine(new string('!', 20));
                m.Invoke();
            };
            m();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Finally");
        }
    }
}