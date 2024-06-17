
MyClass<string> instance1 = new MyClass<string>();
MyClass2<int> instance2 = new MyClass2<int>();

//where T: class - Аргумент типа должен иметь ссылочный тип,
//это также распространяется натип любого класа,
//интерфейс
class MyClass<T> where T: class
{
    public T variable;
}
//where T: struct - Фргумент типа должен иметь тип значения.
//Допускается указания
//любого типа значения, кроме Nullable
class MyClass2<T> where T: struct
{
    public T variable;
} 