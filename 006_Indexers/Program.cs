using _006_Indexers;

DerivedClass instance = new DerivedClass();
BaseClass instance1 = instance;

for(int i = 0; i < 3; i++)
{
    Console.WriteLine(instance1[i]);
}
