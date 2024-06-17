
MyClass instance = new MyClass();
instance.Method<string>("Hello wodrld!");

instance.Method("Привет мир!");


//укаазтель места заполнения типом
class MyClass
{
    public void Method<T>(T arg)
    {
        T var = arg;
        Console.WriteLine(var);
    }
}