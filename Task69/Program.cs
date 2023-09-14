// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите натуральное число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа : ");
int B = Convert.ToInt32(Console.ReadLine());

int PowDigitNumbers(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * PowDigitNumbers(num1, num2 - 1);
}

Console.WriteLine(PowDigitNumbers(A, B));
