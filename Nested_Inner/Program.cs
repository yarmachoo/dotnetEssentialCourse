//Inner класс
public class OuterForInner
{
    public void anOuterForInnerMethod()
    {
        Console.WriteLine("anOuterForInnerMethod");
    }
    public class Inner
    {
        public void anInnerMethod()
        {
            Console.WriteLine("anInnerMethod");
        }
    }
}
//Nested класс
public class OuterForNested
{
    public void OuterForNestedMethod()
    {
        Console.WriteLine("OuterForNestedMethod");
    }
    public static class Inner
    {
        public static void NestedMethod()
        {
            Console.WriteLine("NestedMethod");
        }
    }
}