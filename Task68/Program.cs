// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1 || number2 < 1)
{
    Console.WriteLine($"Ошибка ввода!");
    return;
}
int AkkermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0 && n != 0) return AkkermanFunction(n - 1, 1);
    else 
    return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}

Console.WriteLine(AkkermanFunction(number1, number2));