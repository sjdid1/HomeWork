// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArray(double[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double[] arr = CreateArrayRndDouble(5, 0, 10);
PrintArray(arr);
Array.Sort(arr);
if (arr.Length > 0)  Console.Write(" -> " + Math.Round((arr[arr.Length - 1] - arr[0]),1));



