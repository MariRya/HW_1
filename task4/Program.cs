Console.WriteLine("Введите первое число");
string s = Console.ReadLine();
int a = int.Parse(s);

Console.WriteLine("Введите второе число") ;
string t = Console.ReadLine();
int b = int.Parse(t);

Console.WriteLine("Введите третье число") ;
string u = Console.ReadLine();
int c = int.Parse(u);

if (a > b && a > c )
{
    Console.WriteLine($"max число {a}") ;
}
if (b > a && b > c )
{
    Console.WriteLine($"max число {b}") ;
}
if (c > a && c > b )
{
    Console.WriteLine($"max число {c}") ;
}