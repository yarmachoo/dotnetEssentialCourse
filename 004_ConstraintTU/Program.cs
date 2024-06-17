
MyClass<Derived> mc1 = new MyClass<Derived>();
//MyClass<IInterface> mc2 = new MyClass<IInterface>();


MyClass2<IInterface> mc2 = new MyClass2<IInterface> ();
MyClass2<Derived> mc3 = new MyClass2<Derived>();

MyClass3<IInterface<object>> mc4 = new MyClass3<IInterface<object>>();
interface IInterface { }
interface IInterface<U> { }

class Derived:  IInterface, IInterface<object> { }
//where T : IInterface, IInterface<object> - Аргумент типа должен являться 
//или роеализовывать указанный интерфейс.
//Можно установить несколько ограничений интерфейса.
//Ограничивающий интерфейс также может быть универсальным.
class MyClass<T> where T : IInterface, IInterface<object> { }
class MyClass2<T> where T : IInterface { }
class MyClass3<T> where T :  IInterface<object> { }