

B b = new B();
b.DoSomething();


class A
{
    public void DoSomething()
    {
        Console.WriteLine("Action");
    }
}
class B
{
    public void DoSomething()
    {
        A a = new A();
        a.DoSomething();
    }
}
