using _002_Indexers;

MyClass myClass = new MyClass();

for (int i = 0; i < 5; i++)
{
    myClass[i] = $"i = {i}";
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(myClass[i]);
}