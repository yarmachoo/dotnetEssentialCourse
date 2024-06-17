
//Инициализация СТАТИЧЕСКИХ полей не обязательна
//MyStruct.Field = 1;

MyStruct.Show();


//Структуры могут содержать статические члены

//Статические структуры недопустимы.
//(не можем создать статическую структуру
//(static struct Name - такого нет в С#))
struct MyStruct
{   
    public static int Field
    {
        get;
        set;
    }
    public static void Show()
    {
        Console.WriteLine(Field);
    }
}