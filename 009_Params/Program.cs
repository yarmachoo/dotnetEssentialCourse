

ShowArrays("Numbers: ", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0);

static void ShowArrays(string name, params int[] array)
{
    Console.WriteLine($" Name is {name}");
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
}