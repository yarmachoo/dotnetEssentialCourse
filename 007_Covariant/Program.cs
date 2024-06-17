Dog[] dogs = { new Dog(), new Dog(), new Dog() };

for(int i = 0; i<dogs.Length; i++)
{
    dogs[i].Voice();
    dogs[i].Jamp();
}

Console.WriteLine(new string('-', 50));

IAnimal[] animals = dogs;

for (int i = 0; i < animals.Length; i++)
{
    animals[i].Voice();
    //animals[i].Jamp();
}

public interface IAnimal
{
    void Voice();
}

public class Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Gav");
    }
    public void Jamp()
    {
        Console.WriteLine("jamp");
    }
}

