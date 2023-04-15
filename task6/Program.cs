Console.WriteLine("Введите число");
string text = Console.ReadLine();
int number = int.Parse(text);

if (number % 2 == 0)
{
    Console.WriteLine($"Да, {number} - четное") ;
}
else 
{
    Console.WriteLine($"Нет, {number} - нечетное") ;
} 
