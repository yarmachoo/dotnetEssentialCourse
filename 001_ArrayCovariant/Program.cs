
Dog[] dogs =
{
    new Dog(),
    new Dog(),
    new Dog()
};

//IAnimal[] animal = dogs;//Ковариантность

//Массивы элементов ссылочного типа в C# ковариантны но не котрвариантны
//Массивы элементов структурных типов и не ковариантны и не контрвариантны
public interface IAnimal
{
    void Voice();
}
public struct Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Voice");
    }
}
