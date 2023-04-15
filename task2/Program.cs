Console.WriteLine("Введите первое число") ;
string s = Console.ReadLine();
int a = int.Parse(s);

Console.WriteLine("Введите второе число") ;
string t = Console.ReadLine();
int b = int.Parse(t);

if (a > b)
{
    Console.WriteLine($"max число {a}") ;
    Console.Write($"min число {b}") ;
}

else if (a < b)
{
    Console.WriteLine($"max число {b}") ;
    Console.Write($"min число {a}") ;
}

else if (a == b)
{
    Console.Write($"Числа равны") ;
    
}