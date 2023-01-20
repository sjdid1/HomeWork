// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Введите натуральное положительное число");
    return;
}
else Quarter(number);

void Quarter(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}      {count * count * count}");
        count++;
    }
}