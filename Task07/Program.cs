
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int div = number % 10;

    Console.WriteLine(div);
}
else
{
    Console.WriteLine("Введите натуральное число");
}