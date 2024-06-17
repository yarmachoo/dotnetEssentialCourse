
MyClass.Nested instance = new MyClass.Nested();

instance.Method(1);

class MyClass
{
    private static int field = 0;
    public class Nested
    {
        public void Method(int a)
        {
            field = a;
            Console.WriteLine(field);
        }
    }
}