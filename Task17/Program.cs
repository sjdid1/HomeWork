﻿// 17. Напишите программу, которая принимает на вход
// координаты точки (xc и yc), причём xc ≠ 0 и yc ≠ 0 и 
//выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки: ");
Console.Write ("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write ("y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x,y);
string result = quarter > 0 
? $"Указанные координаты соответствуют {quarter} четверти" 
: "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}


