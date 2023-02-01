// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());  

//k1*x + b1 = k2*x + b2   k1*x - k2*x = b2 - b1   x = (b2 - b1)/(k1 - k2)

double CoordinateX(int bx1, int kx1, int bx2, int kx2)
{
    double x = Convert.ToDouble(bx2 - bx1) / (kx1 - kx2);
  
    return x;
}
double CoordinateY(int bx1, int kx1, int bx2, int kx2)
{
    double y = (kx1 * Convert.ToDouble(bx2 - bx1) / (kx1 - kx2)) + bx1;
    
    return y;
}
double coordinatex = CoordinateX(b1, k1, b2, k2);
double coordinatey = CoordinateY(b1, k1, b2, k2);
Console.Write("(");
Console.Write($"{coordinatex}, {coordinatey}");
Console.Write(")");
