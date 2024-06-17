using _001_Yield;
using System.Collections;

UserCollection myCollection = new UserCollection();

//Element - переменная итерации
//поочередно извлекаем значения из коллекции в переменную итерации
foreach (var item in UserCollection.Power())
    Console.WriteLine($"{item}");


//Устройство коллекции:
//foreach приводит коллекцию к интерфейсному типу IEnumerable
IEnumerable enumerable = UserCollection.Power();

//foreach - приводит коллекцию к  интерфейсному типу вызывая метод - GetEnumerator()
IEnumerator enumerator = enumerable.GetEnumerator();

while (enumerator.MoveNext())
{
    string? element = enumerator.Current as string;
    Console.WriteLine($"{element}");
}

//TODO: удалить 
