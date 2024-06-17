
//Создание экземпляра пользовательского типа, с вызовом
//пользовательского конструктора
MyStruct instance = new MyStruct(33) { field = 666 };

Console.WriteLine(instance.field);

struct MyStruct
{
    public int field;
    ///Статический конструктор всегда отрабатывает первым!
    static MyStruct()
    {
        Console.WriteLine("Static constructor");
    }
    //Если в струтктуре имеется пользовательский конструктор, 
    //то требуется в нем инициализировать все поля.
    public MyStruct(int value)
    {
        Console.WriteLine("constructor");
        this.field = value;
    }

}