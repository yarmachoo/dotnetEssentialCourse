using System.Collections;

ArrayList arrayList = new ArrayList();

//Boxing
arrayList.Add(1);
arrayList.Add((object)2);

int i1 = (int)arrayList[0];

for(int i = 0; i<arrayList.Count; i++)
    Console.WriteLine((int)arrayList[i]);

Console.WriteLine(new string('-', 50));

List<int> list = new List<int>();

//Упаковки нет!
list.Add(3);
list.Add(2);

//распаковки нет!
int i3 = list[0];

