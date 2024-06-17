
using System.Diagnostics;

class MyClass: ICloneable
{
    int a, b;
    public MyClass()
    {
        Thread.Sleep(1000);
        a = new Random().Next(1, 100);
        Thread.Sleep(1000);
        b = new Random().Next(1, 100);
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        MyClass original = new MyClass();

        stopwatch.Stop();

        Console.WriteLine("original построен за {0}", stopwatch.Elapsed.Ticks);

        stopwatch.Reset();

        stopwatch.Start();
        MyClass clone = original.Clone() as MyClass;

        stopwatch.Stop();

        Console.WriteLine("clone построен за    {0}", stopwatch.Elapsed.Ticks);



    }
}