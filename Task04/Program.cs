// Задача 4: Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    int max = numberA;
    if (max > numberC)
    {
        Console.WriteLine($"max = {max}");
    }
    else
    {
        max = numberC;
        Console.WriteLine($"max = {max}");
    }
}
else
{
    if (numberB > numberC)
    {
        int max = numberB;
        Console.WriteLine($"max = {max}");
    }
    else
    {
        int max = numberC;
        Console.WriteLine($"max = {max}");
    }
}