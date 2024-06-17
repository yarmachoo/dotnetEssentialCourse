

//От структур нельзя наследоваться. 

struct MyStruct
{
    public void Method()
    {
        Console.WriteLine("Method");
    }
}

class MyClass //: MyStruct
{
}