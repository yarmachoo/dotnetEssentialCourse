
int? a = null;
int? b = -5;

//При сравнении операндов один из который null 
//результатом сравнени явсегда будет false
//следовательно, нельзя рассчитывать на истинность.

if (a >= b)
{

    Console.WriteLine("a>=b");
}
else
{

    Console.WriteLine("a<b");
}


//Сравнивать операнды (Nullable) есть смысл
//только тогда, когда оба содержат null
//null == null -> true


b = null;

if(a==b)
    Console.WriteLine("a == b");
else
    Console.WriteLine("a != b");