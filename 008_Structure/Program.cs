MyStruct instance = new MyStruct();
instance.MyProperty = 1;
Console.WriteLine(instance.MyProperty);

//В структурах можно создавать автоматически реализуемые свойства.
//При этом требуется использовать конструктор при построении экземпляра.
struct MyStruct
{
    public int MyProperty {  get; set; }

}