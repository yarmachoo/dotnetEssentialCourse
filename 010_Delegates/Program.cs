﻿

Delegate1 delegate1 = new Delegate1(MyClass.Method1);

Delegate2 delegate2 = delegate1();

delegate2();


class MyClass
{
    public static Delegate2 Method1()
    {
        return new Delegate2(Method2);
    }
    public static void Method2()
    {
        Console.WriteLine("Hello World!!");
    }
}


delegate Delegate2 Delegate1();
delegate void Delegate2();