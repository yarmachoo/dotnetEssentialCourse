
//Nullable - структура

Nullable<int> a = 1;

if (a.HasValue == true)
    Console.WriteLine($"a is {a.Value}");


//Короткая нотация Nullable типа ?
int? b = 1;

if (b.HasValue == true)
{

    Console.WriteLine($"b is {b.Value}");
}


//неявно типизированная локальная переменная не может быть Nullable
//var? c = null;

