

MyStruct my = new MyStruct();

//Упаковка (Boxing)
ValueType vt = my;

//Распаковка (UnBoxing)
MyStruct unboxed = (MyStruct)vt;
struct MyStruct //:ValueType
{
    public void Method()
    {
        Console.WriteLine("Method");
    }
}