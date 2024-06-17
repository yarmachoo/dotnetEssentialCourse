




MyDelegate myDelegate = MyClass.Method;

myDelegate();

public class MyClass
{
    public static void Method()
    {
        Console.WriteLine("Method");
    }
}

public delegate void MyDelegate();