// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//                   БЕЗ МЕТОДА

/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number /= 10;
    }
    int result = number % 10;
    Console.WriteLine($"Третья цифра {result}");
}

*/

//                     С МЕТОДОМ


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Digit(int num)
{
    while (num > 999)
        num /= 10;
    return num % 10;
}

if (number < 0)
{
    number = -number;
}
if (number <= 99 && number >= -99)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    int digit = Digit(number);
    Console.WriteLine($"Третья цифра {digit}");
}

