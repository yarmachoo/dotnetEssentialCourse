
int summand1 = 1, summand2 = 2, sum = 0;

MyDelegate myDelegate = delegate (ref int a, ref int b, out int c) { a++; b++; c = a + b; };

myDelegate(ref summand1, ref summand2, out sum);

Console.WriteLine($"{summand1} + {summand2} = {sum}");

public delegate void MyDelegate(ref int a, ref int b, out int c);

