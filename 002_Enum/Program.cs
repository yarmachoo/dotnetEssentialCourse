
Enum one = EnumType.One;
Console.WriteLine(one);

//Console.WriteLine((byte)one);

Console.WriteLine(new string('-', 50));

for(EnumType number = EnumType.Zero; number <= EnumType.Three; number++)
{
    Console.WriteLine((byte)number);
}
enum EnumType : byte //по умолчанию общий тип констант int
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3,
}