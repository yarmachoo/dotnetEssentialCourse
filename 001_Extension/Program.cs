
//Расширяющие методы (Extension methods)
//Расширяющие методы могут быть только статические
//и создаваться только в статически классах


string text = "Текстовая строка";
///вызов метода как статичекого
ExtensionClass.ExtensionMethod(text);
///вызов метода, как расширяющего
text.ExtensionMethod();


//int a = 4;

//a.ExtensionMethod();

static class ExtensionClass
{
    //this - сообщает компилятору, что данный метод является
    //расширением (Extension)!
    public static void ExtensionMethod(this string value)
    {
        Console.WriteLine(value);
    }
}