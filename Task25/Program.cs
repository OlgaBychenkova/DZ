// Напишите программу, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowNumber(int num, int n)
{
    int res = 1;
    for(int i = 0; i < n; i++)
    {
        res *= num;
    }
    return res;
}

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = PowNumber(number1, number2);
Console.WriteLine($"{number1} в степени {number2} -> {result}");
