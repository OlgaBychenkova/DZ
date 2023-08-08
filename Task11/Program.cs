// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98



int randNumber = new Random().Next(100, 1000);

int shortNumber = RemoveSecondDigit(randNumber);

Console.WriteLine($"Случайное трехзначное число: {randNumber}");
Console.WriteLine($"Результат удаления второго числа: {shortNumber}");



int RemoveSecondDigit(int num)
{
    int first = num / 100;
    int second = num % 10;
    int result = first * 10 + second;

    return result;
}

