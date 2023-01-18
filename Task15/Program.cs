// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


//      БЕЗ МЕТОДА
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = { 1, 2, 3, 4, 5, 6, 7 };
if (number > 7 | number <= 0)
{
    Console.WriteLine("Другое число");
}
else if (number == array[5] | number == array[6])
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
*/
//        С МЕТОДОМ

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0 || number >= 8)
{
    Console.WriteLine("Введите другое число");
}
else
{
bool Week (int num)
{
    return num == 6 || num == 7;
}
bool result = Week(number);
Console.WriteLine(result ? "да" : "нет");
}
