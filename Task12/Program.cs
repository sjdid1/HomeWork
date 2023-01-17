// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

//БЕЗ МЕТОДА

/*
Console.Write("a= ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b= ");
int b = Convert.ToInt32(Console.ReadLine());

int c = a % b;

if (c == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {c}");
}
*/


//С МЕТОДОМ

Console.WriteLine("Введите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int Div(int num1, int num2)
{
    return num1 % num2;
}

int div = Div(a, b);

if (div == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {div}");
}
