// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

//БЕЗ МЕТОДА

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int firstDigit = number / 100;
// int secondDigit = number % 10;

// Console.WriteLine($"{firstDigit}{secondDigit}");

//С МЕТОДОМ

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int digitNumber = DigitNumber(number);
Console.WriteLine($"Ответ => {digitNumber}");

int DigitNumber(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit*10 + secondDigit;
}





