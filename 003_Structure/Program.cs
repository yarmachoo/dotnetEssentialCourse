MyStruct instance = new MyStruct();

instance.field = 3;

Console.WriteLine(instance.field);

struct MyStruct
{
    public int field;
    //Конструкторы по умолчанию нельзя задавать явно
    //public MyStruct()
    //{

    //}
    //Если в конструкторе имеется пользовательский конструктор,
    //то требуется в нем инициализировать в се поля
    public MyStruct(int value)
    {
        Console.WriteLine("Constructor");
        this.field = value;
    }
}