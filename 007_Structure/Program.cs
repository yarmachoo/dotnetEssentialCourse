
//Создание экземпляра пользовательского типа, без вызова конструктора
MyStruct instance;

//Нельзя использовать не инициализированную переменную.
//Так как конструктор не вызвался, переменная field осталась не иниц.

//Console.WriteLine(instance.field);

struct MyStruct
{
    public int field;
    
    public MyStruct(int value)
    {
        Console.WriteLine("constructor");
        this.field = value;
    }

}