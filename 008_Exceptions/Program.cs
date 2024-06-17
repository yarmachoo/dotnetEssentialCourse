class Program
{
    public static void Method()
    {
        int[] arr = new int[10000000];
        Console.WriteLine(arr);
        Method();
    }
    static void Main()
    {
        try { Method(); }
        catch (Exception e) { Console.WriteLine(e.Message); }
        finally { Console.WriteLine("Finally"); }
    }
}