// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите положительное число 1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите положительное число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Некорректный ввод: введите положительные числа");
    return;
}
int Akkerman(int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    if (num1 > 0 && num2 == 0)
        return Akkerman(num1 - 1, 1);
    else
        return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
}
Console.WriteLine($"A({number1}, {number2}) = {Akkerman(number1, number2)}");