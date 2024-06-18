
//into - подобно let, позволяет определить локальный по отношению к запросу идентификатор.

int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//Разделение чисел на четные и нечетные

var query = from x in nums
            group x by x % 2 into partition
            where partition.Key == 0
            select new { Key = partition.Key, Count = partition.Count(), Group = partition };

foreach (var item in query)
{
    Console.WriteLine($"mod2 == {item.Key}");
    Console.WriteLine($"Count == {item.Count}");

    foreach (var num in item.Group)
        Console.Write(num + ", ");

    Console.WriteLine();
}