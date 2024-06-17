


MyClass.Nested instance = new MyClass.Nested();

instance.Method();

class MyClass
{
    public class Nested
    {
        public void Method()
        {
            Console.WriteLine("Метод из Nested класса");
        }
    }
}