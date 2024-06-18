public class Result
{
    public Result(int input, int outout)
    {
        Input = input;
        Output = outout;
    }
    public int Input { get; set; }
    public int Output { get; set; }
}
class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4 };

        var query = from x in nums
                    select new Result( x, x * 2 );

        nums[0] = 777;
        //Выражение запроса выполняется в момент обращения к переменной запроса в foreach

        foreach( var x in  query )
        {
            Console.WriteLine($" Input = {x.Input} \t Output = {x.Output}");
        }
    }
}