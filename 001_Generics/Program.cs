
//создаем экземпляр класса MyClass и закрываем его типом int
//инстанцируем касс MyClass и закрываем его типом int

MyClass<int> myClass = new MyClass<int>();
myClass.Method(); ;

//укаазтель места заполнения типом
class MyClass<T>
{
    public T field;
    public void Method()
    {
        Console.WriteLine(field.GetType());
    }
}