
//Создание экземпляра структурного типа, c вызовом конструктора
MyStruct instance = new MyStruct();

instance.Fieald = 3;

Console.WriteLine(instance.Fieald);

//Если в структуре имеются члены, которые обращаются к полю и нет
//пользовательского конструктора, то требуется при создании экземпляра
//вызвать конструктор по умолчани. (Иначе будет ошибка).
struct MyStruct
{
    private int field;
    public int Fieald
    {
        get { return field; }
        set { field = value; }
    }
    public void Show()
    {
        Console.WriteLine(field);
    }
}

