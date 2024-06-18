//Анонимные типы (сильная ссылка)

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
        var instance = new { My = new MyClass() };

        instance.My.field = 1;
        instance.My.Method();
    }
}