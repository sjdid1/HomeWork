// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1 )
    {
        return true;
    }
    else return false;
}

bool triangle = Triangle(number1, number2, number3);
Console.WriteLine(triangle ? "Существует" : "Не существует");
