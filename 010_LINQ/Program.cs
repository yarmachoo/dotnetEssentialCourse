class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4 };

        var query = from x in nums
                    select new { Input = x, Output = x*2};

        nums[0] = 777;
        //Выражение запроса выполняется в момент обращения к переменной запроса в foreach

        foreach (var x in query)
        {
            Console.WriteLine($" Input = {x.Input} \t Output = {x.Output}");
        }
    }
}