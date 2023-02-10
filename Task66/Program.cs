// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в 
// промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
    SumNaturalNumbers(number1, number2);
    Console.WriteLine($"M = {number1}; N = {number2} -> {SumNaturalNumbers(number1, number2)}");
}
else
{
    SumNaturalNumbers(number2, number1);
    Console.WriteLine($"M = {number1}; N = {number2} -> {SumNaturalNumbers(number2, number1)}");
}

int SumNaturalNumbers(int num1, int num2)
{
    if (num1 == num2) return num2;
    {
        return num2 + SumNaturalNumbers(num1, num2 - 1);
    }
}

