

MyDelegate myDelegate = null;

MyDelegate myDelegate1 = new MyDelegate(MyClass.Method1);
MyDelegate myDelegate2 = new MyDelegate(MyClass.Method2);
MyDelegate myDelegate3 = new MyDelegate(MyClass.Method3);

myDelegate = myDelegate1+myDelegate2+myDelegate3;

Console.WriteLine("ВВедите число от 1 до 7");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        myDelegate1();
        break;
    case 2: 
        myDelegate2();
        break;
    case 3:
        myDelegate3();
        break;
    case 4:
        MyDelegate myDelegate4 = myDelegate - myDelegate1;
        myDelegate4.Invoke();
        break;
    case 5:
        MyDelegate myDelegate5 = myDelegate - myDelegate2;
        myDelegate5.Invoke();
        break;
    case 6:
        MyDelegate myDelegate6 = myDelegate - myDelegate3;
        myDelegate6.Invoke();
        break;
    case 7: 
        myDelegate.Invoke();
        break;
    default:
        Console.WriteLine("вы ввели неверное значеие");
        break;
}
public static class MyClass
{
    public static void Method1()
    {
        Console.WriteLine("method1");
    }
    public static void Method2()
    {
        Console.WriteLine("method2");
    }
    public static void Method3()
    {
        Console.WriteLine("method3");
    }
}

public delegate void MyDelegate();