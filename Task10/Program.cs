// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначноне число ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 99 || number > 1000)
{
    Console.WriteLine($"Некорректное число. Повторите попытку "); 
    number = Convert.ToInt32(Console.ReadLine());
}

int number1 = PrintSecondDigital(number);
Console.WriteLine($"Второе число: {number1}");

int PrintSecondDigital(int num)
 {
    int first = num % 100;
    int second = num % 10;
    int result = (first  - second) / 10;
    return result;   
}

