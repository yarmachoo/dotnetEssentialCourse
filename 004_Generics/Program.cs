
MyDelegate<int, int> myDelegate = new MyDelegate<int, int>(MyClass.Add);
Console.WriteLine(myDelegate(1));


delegate R MyDelegate<T, R>(T t);
class MyClass
{
    public static int Add(int i)
    {
        return ++i;
    }
    public static string Concatenation(string s)
    {
        return "Hello " + s + "!";
    }
}