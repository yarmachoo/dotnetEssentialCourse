
string text = "Hello ";
text.ExtensionMethod("word!");
text.ExtensionMethod();

2.ExtensionMethod();
///Расширяющие методы не могут иметь опциональных параметров, 
///но могут быть перегруженными

static class ExtensionClass
{
    public static void ExtensionMethod(this string value)
    {
        Console.WriteLine(value);
    }
    public static void ExtensionMethod(this string value1, string value2)
    {
        Console.WriteLine(value1 + value2);
    }
    public static void ExtensionMethod(this int value)
    {
        Console.WriteLine(value);
    }
}
