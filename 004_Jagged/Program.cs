﻿int[][] jagged = new int[3][];

jagged[0] = new int[] { 1, 2, 3 };
jagged[1] = new int[] { 4, 5 };
jagged[2] = new int[] { 6, 7, 8, 9 };

for(int i =0; i<jagged.Length; i++)
{
    for(int j = 0; j < jagged[i].Length; j++)
    {
        Console.Write($"{jagged[i][j]} ") ;
    }
    Console.WriteLine();
}