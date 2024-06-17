
MyDelegate<Cat> delegateCat = new MyDelegate<Cat>(MyClass.CatCreator);
MyDelegate<Animal> delegateAnimal = delegateCat;
Animal animal = delegateAnimal();

Console.WriteLine(animal.GetType().Name);

class Animal { }
class Cat: Animal { }
delegate T  MyDelegate<out T>();//out - для возвращаемого типа

class MyClass
{
    public static Cat CatCreator()
    {
        return new Cat();
    }
}