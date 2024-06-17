//перегрузка операторов явного преобразования типа
//Ключевое слово explicit служит для создания оператора явного преобразования типа
struct Digit
{
    public byte value;
    Digit(byte value)
    {
        this.value = value;
    }
    //Оператор явного преобразования типа byte-to-Digit
    public static explicit operator Digit(byte argument) 
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
        //явное преобразование типа byte-to-Digit
        Digit digit = (Digit)variable;

        Console.WriteLine(digit);
    }
}