// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

//      БЕЗ МЕТОДА
/*
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 ==0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Нет");
}
*/

//      С МЕТОДОМ


Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

bool Div(int number)
{
    return ((number % 7 ==0) && (number % 23 == 0));
}
bool result = Div(a);

if (result == true)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("Нет");
}