// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multi(int num)
{
    int multi = 1;
    if (num < 0) num = num * -1;
    for (int i = 1; i <= num; i++)
    {
        multi = i * multi;
    }
    return multi;
}
int result = Multi(number);
Console.WriteLine(result);