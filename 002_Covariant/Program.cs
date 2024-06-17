uint[] array = new uint[3];

Console.WriteLine($"array {array is uint[]} {array is int[]}");

object @object = array;

Console.WriteLine($"object {@object is uint} {@object is int[]}");