using _004_Nested;

MyClass instance1 = new MyClass();

instance1.MethodFromBase();

MyClass.Nested instance2 = new MyClass.Nested();

instance2.MethodFromNested();

class MyClass : BaseClass 
{
    public class Nested //Наследование от BaseClass не распространяется
    {
        public void MethodFromNested()
        {
            Console.WriteLine("метод Nested класса");
        }
    }
}