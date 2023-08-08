// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000); 
Console.WriteLine($"Случайное число из диапазона 100 - 999 -> {number}");

int number1 = PrintSecondDigital(number);
Console.WriteLine($"Второе число: {number1}");

int PrintSecondDigital(int num)
{
    int first = num % 100;
    int second = num % 10;
    int result = (first  - second) / 10;

    return result;
}
