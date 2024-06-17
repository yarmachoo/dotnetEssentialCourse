
MyClass<TestClass> instance1 = new MyClass<TestClass>();
instance1.instance.MyIntProperty = 1;
instance1.instance.MyStringProperty = "Hello";
instance1.GetValues();

//where T : new() - Аргумень типа должен иметь открытый конструктор без параметров
//При использовании с другими ограничениями, ограничение new() должноустанавливаться последним
//class MyClass<T> where T : class, new()
class MyClass<T> where T : new()
{
    public T instance = new T();

    public void GetValues()
    {
        Console.WriteLine(instance.ToString());
    }
}

class TestClass
{
    public int MyIntProperty { get; set; }
    public string MyStringProperty { get; set;}
    public override string ToString()
    {
        return string.Format("{0} - {1}", MyIntProperty, MyStringProperty);
    }
}
