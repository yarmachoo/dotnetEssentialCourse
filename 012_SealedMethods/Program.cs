class ClassA
{
    public virtual void Method1()
    {
        Console.WriteLine("ClassA.Method1");
    }
    public virtual void Method2()
    {
        Console.WriteLine("ClassA.Method2");
    }
}

class ClassB: ClassA
{
    public sealed override void Method1()
    {
        Console.WriteLine("ClassB.Method1");
    }
    public override void Method2() { Console.WriteLine("ClassB.Method2"); }
}

class ClassC: ClassB
{
    //Error public override void Method1();
    public override void Method2()
    {
        Console.WriteLine("ClassC.Method2");
    }
}