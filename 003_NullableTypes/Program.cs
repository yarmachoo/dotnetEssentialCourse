int? a = null;
int? b; //по умолчанию null а не 0

b = a ?? 10; //операция поглащения b = 10
//b = a!=null?a:b; //эквивалентно поглощению 

Console.WriteLine(b);

a = 3;
b = a ?? 10;

Console.WriteLine(b);