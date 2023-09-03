// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10


using System.Globalization;

int DecimalToBin(int num)
{
    int res = 0;
    int factor = 1;
    while (num > 0)
    {
        res += num % 2 * factor;
        num /= 2;
        factor *= 10;
    }
    return res;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int decimalToBin = DecimalToBin(number);
Console.WriteLine(decimalToBin);


