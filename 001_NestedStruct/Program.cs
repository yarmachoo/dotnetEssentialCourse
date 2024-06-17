
MyStruct.Nested instance = new MyStruct.Nested();
instance.Method();

struct MyStruct
{
    public struct Nested
    {
        public void Method()
        {
            Console.WriteLine("Nested");
        }
    }
}