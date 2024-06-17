

MyStruct instance;
instance.Method();


//Наследование структур разрешено только от интерфейса
//Наследование структур от классов и струтур запрещено!

interface IInterface
{
    void Method();
}
struct MyStruct : IInterface
{
    public void Method()
    {
        Console.WriteLine("Method");
    }
}