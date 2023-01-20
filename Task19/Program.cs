// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> не
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 9999 && -9999 < number)
{
    Console.WriteLine("Введите пятизначное число");
    return;
}
bool Polin(int num)
{
    {
        return ((num % 10 == num / 10000) && (num / 1000) % 10 == (num % 100) / 10);
    }
}
bool result = Polin(number);
if (result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}