using _005_Inheritance;

DerivedClass instance =  new DerivedClass();

instance.field1 = 1;
instance.field2 = 2;
instance.field3 = 3;
instance.field4 = 4;
instance.field5 = 5;


//каст - приведение к базовому типу (upcast)
BaseClass newInstance = (BaseClass)instance;

Console.WriteLine(newInstance.field1);
Console.WriteLine(newInstance.field2);
Console.WriteLine(newInstance.field3);

//Console.WriteLine(newInstance.field4);
//Console.WriteLine(newInstance.field5);

Console.WriteLine($"instance Id  {instance.GetHashCode()}");
Console.WriteLine($"instance Id  {newInstance.GetHashCode()}");