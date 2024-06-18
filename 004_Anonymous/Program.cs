//Анонимные типы (слабая ссылка)
class MyClass
{
    public int field;
    public void Method()
    {
        Console.WriteLine(field);
    }
}
class Program
{
    static void Main()
    {
        new
        {
            My = new MyClass { field = 1}
        }.My.Method();
    }
}