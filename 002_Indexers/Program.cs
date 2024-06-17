using _002_Indexers;

MyClass myClass = new MyClass();

myClass[0] = "Hello";
myClass[1] = "Hello1";
myClass[2] = "Hello2";

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(myClass[i]);
}