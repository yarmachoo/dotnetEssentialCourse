using _005_Indexers;

Dictionary myDict = new Dictionary();

Console.WriteLine(myDict["яблоко"]);
Console.WriteLine(myDict["котик"]);

Console.WriteLine();

for (int i =0; i<5; i++)
{
    Console.WriteLine(myDict[i]);
}