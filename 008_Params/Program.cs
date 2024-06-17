ShowArray(0, 1, 2, 3, 4, 5);

static void ShowArray(params int[] array)
{
    for( int i = 0; i< array.Length; i++ )
    {
        Console.WriteLine($"{array[i]} ");
    }
}