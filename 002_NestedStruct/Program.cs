
MyStruct.Nested instance = new MyStruct.Nested();
instance.Method();
//Структуры могут содержать вложенные классы.

struct MyStruct
{
    public class Nested
    {
        public void Method()
        {
            Console.WriteLine("Nested");
        }
    }
}