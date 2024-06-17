

Functional functional = new Functional(MyClass.MethodF);
Delegate3 delegate3 = functional.Invoke(new Delegate1(MyClass.Method1), new Delegate2(MyClass.Method2));

Console.WriteLine(delegate3());

class MyClass
{
    public static Delegate3 MethodF(Delegate1 delegate1, Delegate2 delegate2)
    {
        return delegate { return delegate1.Invoke() + delegate2.Invoke(); };
    }

    public static string Method1() { return "hello1!"; }
    public static string Method2() { return "hello2!"; }
}

public delegate Delegate3 Functional(Delegate1 delegate1, Delegate2 delegate2);
public delegate string Delegate1();
public delegate string Delegate2();
public delegate string Delegate3();