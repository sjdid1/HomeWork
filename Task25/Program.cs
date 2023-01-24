// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите натуральное число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b < 0) b = -b;
if (a < 0) a = -a;
int Degree(int numberA, int numberB)
{

    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result = numberA * result;
    }
    return result;
}
int degree = Degree(a, b);
Console.WriteLine($"{a}, {b} -> {degree}");