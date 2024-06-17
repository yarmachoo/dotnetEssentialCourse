//использование блока инициализатора
int[] array = { 1, 2, 3, 4, 5 };

array = new int[5];

array = new int[5] { 1, 2, 3, 4, 5 };

array = new int[] { 1, 2, 3, 4, 5 };

foreach(var el in array)
{
    Console.WriteLine(el);
}