
MyClass<Base> mc1 = new MyClass<Base>();
MyClass<Derived> mc2 = new MyClass<Derived>();

class Base { }
class Derived: Base { }
//where T : Base - Аргумент типа должен являться
//или быть производным от указанного базового класса 
class MyClass<T> where T : Base { }