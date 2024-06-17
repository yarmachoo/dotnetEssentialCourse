
MyClass.Nested instance = new MyClass.Nested();


//Статические классы могут в себе содержать нестатические Nested  классы
public static class MyClass
{
    static MyClass()
    {
        Console.WriteLine("Статический конструктор MyClass");
    }
    public static void StaticMethod()
    {
        Console.WriteLine("Статический метод класса MyClass");
    }
    public class Nested
    {
        public void Method()
        {
            Console.WriteLine("Метод Nested класса");
        }
    }
}