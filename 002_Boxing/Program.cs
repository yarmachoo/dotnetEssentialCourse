
MyStruct my;
my.Method();

//Boxing (упаковка)
IInterface boxed = my;

boxed.Method();

//UnBoxing (распаковка)
MyStruct unboxed = (MyStruct)boxed;
interface IInterface
{
    void Method();
}
struct MyStruct : IInterface
{
    public void Method()
    {
        Console.WriteLine("Method");
    }
}

