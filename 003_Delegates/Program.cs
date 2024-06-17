
MyClass myClass = new MyClass();

MyDelegate myDelegate = new MyDelegate(myClass.Method);

Console.WriteLine(myDelegate.Invoke("Veronika"));
Console.WriteLine(myDelegate("Euheni"));

class MyClass
{
    public string Method(string name)
    {
        Console.WriteLine("Name: {0}", name);
        return $"Name: {name}";
    }
}

public delegate string MyDelegate (string name);