MyClass<Derived> mc1 = new MyClass<Derived>();
//подходит т к он наследуется от двух интерфейсов


MyClass<IInterface<object>> mc2 = new MyClass<IInterface<object>>();
MyClass2<Derived> mc3 = new MyClass2<Derived>();
MyClass2<Derived2> mc4 = new MyClass2<Derived2>();

MyClass2<IInterface<object>> mc5 = new MyClass2<IInterface<object>>();
//MyClass2<IInterface> mc6 = new MyClass2<IInterface>();

interface IInterface { }
interface IInterface<U> : IInterface { }

class Derived : IInterface, IInterface<object> { }
class Derived2 : IInterface<object> { }
//where T : IInterface, IInterface<object> - Аргумент типа должен являться 
//или роеализовывать указанный интерфейс.
//Можно установить несколько ограничений интерфейса.
//Ограничивающий интерфейс также может быть универсальным.
class MyClass<T> where T : IInterface, IInterface<object> { }
class MyClass2<T> where T : IInterface<object> { }