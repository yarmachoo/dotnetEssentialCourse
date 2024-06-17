

string text = "Hello ";

text.ExtensionMethod(3);

//простая рекурсия!

static class ExtensionClass
{

    public static void ExtensionMethod(this string value, int counter)
    {
        counter--;
        Console.WriteLine(value + counter);

        if (counter != 0)
        {
            value.ExtensionMethod(counter);
        }
        Console.WriteLine(value + counter);
    }
}