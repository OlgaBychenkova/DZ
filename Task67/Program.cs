// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      else return n * FactorialRec(n - 1);
//  }

//  Console.WriteLine(FactorialRec(5));

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigitNumbers(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigitNumbers(num / 10);
}

Console.WriteLine(SumDigitNumbers(number));