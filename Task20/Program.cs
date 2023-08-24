// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double sqrt = Math.Sqrt(5);
// double pow = Math.Pow(3, 5);
// Console.WriteLine(sqrt);
// Console.WriteLine(pow);
// double d = 5.09983461; // 5.09
// double dRound = Math.Round(d, 5, MidpointRounding.ToZero);
// Console.WriteLine(dRound);
// Console.WriteLine($"{d:F}");


double Distance(int x1, int y1, int x2, int y2)
{
    int side1 = x1 - x2;
    int side2 = y1 - y2;
    double distance = Math.Sqrt(side1 * side1 + side2 * side2);
    return distance;
}

Console.WriteLine("Введите координаты 1 точки");
Console.Write("x: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты 2 точки");
Console.Write("x: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine(resultRound);











