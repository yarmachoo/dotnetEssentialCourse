
MyClass myClass = new MyClass();
myClass.CallMethod();
class MyClass
{
    MyClass my = null;//самоассоциация

    private void Method()
    {
        Console.WriteLine("Hello");
    }
    public void CallMethod()
    {
        my = new MyClass();

        my.Method(); //Внутри класса при использованиисвоего же экземпляра 
                     //сокрытие не работает!!
    }
}

