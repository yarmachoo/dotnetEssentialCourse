

MyStruct instance = new MyStruct();

ValueType valueType = instance as ValueType;

Console.WriteLine("Instance = {0}", instance.GetHashCode());
Console.WriteLine("ValueType = {0}", valueType.GetHashCode());


//Все структуры неявно наследуются от абстрактного класса - ValueType

struct MyStruct // : ValueType
{
    public void Method()
    {
        Console.WriteLine("Method");
    }
}