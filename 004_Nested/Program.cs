using _004_Nested;

MyClass.Nested instance = new MyClass.Nested();

instance.MethodFromNested();
instance.MethodFromBase();

class MyClass //Наследование от BaseClass не распространяется
{
    public class Nested: BaseClass
    {
        public void MethodFromNested()
        {
            Console.WriteLine("метод Nested класса");
        }
    }
}