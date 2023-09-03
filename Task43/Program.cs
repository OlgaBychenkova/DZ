// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)






Console.WriteLine("Введите число b1: ");                   
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double x1 = b2 - b1;
double x2 = k1 - k2;
double x = x1 / x2;
double y = k1 * x + b1;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"Координата точки пересечения -> ({x} ; {y})");


// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x * (k1-k2) = b2 -b1
// x = (b2 -b1) / (k1 - k2)


