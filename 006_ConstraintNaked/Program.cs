MyClass<int, object, int> mc1 = new MyClass<int, object, int>();
MyClass<string, object, string> mc2 = new MyClass<string, object, string>();

//ограничения параметров типа - "naked"
class MyClass<T, R, U> where T : U { }

