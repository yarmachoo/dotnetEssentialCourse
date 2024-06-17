

MyClass myClass = new MyClass();

MyDeledate myDeledate = new MyDeledate(myClass.Method);

myDeledate.Invoke(); 

class MyClass
{
    public void Method()
    {
        Console.WriteLine("Метод!");
    }
}

public delegate void MyDeledate();