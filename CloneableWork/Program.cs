
using CloneableWork;

Point original = new Point(1000, 10);

Point clone = original.Clone() as Point;

Console.WriteLine("первая проверка!");
Console.WriteLine(original);
Console.WriteLine(clone);

clone.x = 100;

Console.WriteLine("вторая проверка!");
Console.WriteLine(original);
Console.WriteLine(clone);
