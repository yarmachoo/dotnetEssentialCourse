
Mydelegate mydelegate;

mydelegate = delegate (int x) { return x * 2; }; //Лямбда-метод

mydelegate = (x) => { return x*2; }; //Лямбда-оператор

mydelegate = x => x * 2; //Лямбда-выражение

Console.WriteLine(mydelegate(4));

public delegate int Mydelegate(int a);