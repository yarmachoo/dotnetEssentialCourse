Dictionary<int, string> dict = new Dictionary<int, string>();

dict.Add(0, "Zero");
dict.Add(1, "One");

Console.WriteLine(dict.ContainsValue("Zero"));

for(int i = 0; i<dict.Count; i++)
{
    Console.WriteLine(dict[i]);
}