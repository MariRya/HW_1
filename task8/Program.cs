Console.WriteLine("Введите число ");
string text = Console.ReadLine();
int number = int.Parse(text);
int count = 1;

Console.WriteLine($"Четные числа от 1 до {number}: ");
while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.WriteLine($"{count} ");
        count = count + 1;
    }
    count = count +1;
}








