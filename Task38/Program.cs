// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76




double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2}, ");
        else Console.Write($"{arr[i]:F2}");
    }
    Console.Write("]");
}

double FindMin(double[] arr)
{
double min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if(min > arr[i]) min = arr[i];
}
return min;
}

double FindMax(double[] arr)
{
double max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if(max < arr[i]) max = arr[i];
}
return max;
}


double[] array = CreateArrayRndDouble(4, 1, 100);
PrintArrayDouble(array);
double minimum = FindMin(array);
double maximum = FindMax(array);
double result = maximum - minimum;
Console.WriteLine($" => {maximum:F2} - {minimum:F2} = {result:F2}");