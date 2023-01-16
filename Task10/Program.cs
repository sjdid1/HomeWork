// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
while (number > 99)
{
    number /= 10;
}

int result = number % 10;

Console.WriteLine($"Ответ {result}");
