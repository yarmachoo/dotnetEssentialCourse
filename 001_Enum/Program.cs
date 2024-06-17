
Console.WriteLine(EnumType.One);

Console.WriteLine((byte)EnumType.One);

EnumType digit = EnumType.Two;

Console.WriteLine(digit);
Console.WriteLine((byte)digit);
enum EnumType: byte //по умолчанию общий тип констант int
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3,
}