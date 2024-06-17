//перегрузка операторов неявного преобразования типа
//Ключевое слово implicit служит для создания оператора неявного преобразования типа
struct Digit
{
    public byte value;
    Digit(byte value)
    {
        this.value = value;
    }
    //Оператор неявного преобразования типа byte-to-Digit
    public static implicit operator Digit(byte argument)
    {
        Digit digit = new Digit(argument);
        return digit;
    }
    public override string ToString()
    {
        return this.value.ToString();
    }
}

class MainClass
{
    static void Main()
    {
        byte variable = 1;
        //Неявное преобразование типа byte-to-Digit
        Digit digit = variable;

        Console.WriteLine(digit);
    }
}