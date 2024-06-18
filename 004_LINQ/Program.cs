public static class MySet
{
    public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        Console.WriteLine("Вызвана собственная реализация Where");
        return System.Linq.Enumerable.Where(source, predicate);
    }
    public static IEnumerable<TResult> Select<TSource, TResult>(
            this IEnumerable<TSource> source, Func<TSource, TResult> selector)
    {
        Console.WriteLine("Вызвана собственная реализация Select");
        return System.Linq.Enumerable.Select(source, selector);
    }
}
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4 };
        var query = from number in numbers
                    where number %2 == 0
                    select number * 2;

        foreach ( var number in query )
            Console.WriteLine(number);
    }
}