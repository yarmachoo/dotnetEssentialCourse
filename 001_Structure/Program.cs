
//Создание экземпляра структурного типа, ьез вызова конструктора
MyStruct instance;
instance.field = 1;
Console.WriteLine(instance.field);

//В структурах нельзя инициализировать поля непосредственно в месте создания.
struct MyStruct
{
    public int field;
}

