

//Статические члены не могут быть виртуальными, переопределенными и абстрактными!!
//Статические члены поддерживают замещение!

abstract class BaseClass
{
    //public static virtual void StaticMethod()
    //{
    //    Console.WriteLine("Base.Staticmethod()");
    //}
    public static void StaticMethod()
    {
        Console.WriteLine("Base.Staticmethod()");
    }
}

class DerivedClass: BaseClass
{
    //public static override void StaticMethod()
    //{
    //    Console.WriteLine("derivedClass.StaticMethod()");
    //}
    public static new void StaticMethod()
    {
        Console.WriteLine("derivedClass.StaticMethod()");
    }
}