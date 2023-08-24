
// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).





string RangeCoordinates(int quart)
{
    if(quart == 1) return "x > 0 , y > 0";
    if(quart == 2) return "x < 0 , y > 0";
    if(quart == 3) return "x < 0 , y < 0";
    if(quart == 4) return "x > 0 , y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string rangeCoordinates = RangeCoordinates(quarter);
string result = rangeCoordinates != null ? rangeCoordinates : "Введена некорректная четверть";
Console.WriteLine(result);
