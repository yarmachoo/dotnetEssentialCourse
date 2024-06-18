
//group - является средством для разделения ввода запроса

int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//Разделение чисел на четные и нечетные

var query = from x in nums
            group x by x % 3;

foreach(var group in query)
{
    Console.WriteLine($"mod{group.Key} == {group.Key}");

    foreach(var num in group)
        Console.WriteLine(num);
}