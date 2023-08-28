// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigites(int num)
{
    int sum = 0;
    if (num <= 9) return num;
    while (num > 9)
    {
        sum = num % 10 + num / 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigites(number);
Console.WriteLine($"Сумму чисел {number} = {result}");
