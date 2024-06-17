MyClass.Nested.Method();


//Нестатические классы могут в себе содержать статические Nested классы
public class MyClass
{
    public static class Nested
    {
        public static void Method()
        {
            Console.WriteLine("Метод Nested класса");
        }
    }
}