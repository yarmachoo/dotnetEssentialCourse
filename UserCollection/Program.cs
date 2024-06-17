using System.Collections;
using UserCollection;

MyCollection myCollection = new MyCollection();

//Element - переменная итерации
//поочередно извлекаем значения из коллекции в переменную итерации
foreach(Element item in myCollection)
    Console.WriteLine($"{item.Name} {item.Field1} {item.Field2}");


//Устройство коллекции:
//foreach приводит коллекцию к интерфейсному типу IEnumerable
IEnumerable enumerable = myCollection as IEnumerable;

//foreach - приводит коллекцию к  интерфейсному типу вызывая метод - GetEnumerator()
IEnumerator enumerator = enumerable.GetEnumerator();

while(enumerator.MoveNext())
{
    Element? element = enumerator.Current as Element;
    Console.WriteLine($"{element?.Name} {element?.Field1} {element?.Field2}");
}

enumerator.Reset();

