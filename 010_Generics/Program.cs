
MyDelegate<Animal> delegateAnimal = new MyDelegate<Animal>(MyClass.CatUser);
MyDelegate<Cat> delegateCat = delegateAnimal;

delegateAnimal(new Animal());
delegateCat(new Cat());

class Animal { }
class Cat : Animal { }
delegate void MyDelegate<in T>(T a);//in - для аргумента

class MyClass
{
    public static void CatUser(Animal animal)
    {
        Console.WriteLine(animal.GetType().Name);
    }
}