int[] vector = { 1, 2, 3 };

Array array = vector as  Array;

for(int i = 0; i< array.Length; i++)
{
    Console.WriteLine(vector[i]);
}

Console.WriteLine(vector.GetHashCode());
Console.WriteLine(array.GetHashCode());