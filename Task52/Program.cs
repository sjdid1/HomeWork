// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}

void Average(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int count = 0;
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i, j];
            count++;
        }
        average = Math.Round(average / count, 2);

        Console.Write($"{average} | ");
    }
}
int[,] array2D = CreateMatrixRndInt(4, 4, -50, 50);
PrintMatrix(array2D);
Console.WriteLine("Средние арифметические равны соответсвенно:");
Average(array2D);



