// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                        0       1
    int[,] matrix = new int[rows, columns]; // rows = 3, columns = 4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}


// int SumElementsMainDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j) sum += matrix[i, j];
//         }
//     }
//     return sum;
// }

// int SumElementsMainDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     int size = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
//     for (int i = 0; i < size; i++)
//     {
//         sum += matrix[i, i];
//     }
//     return sum;
// }

int SumElementsMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int size = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        j = i;
        sum += matrix[i, j];
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
int sumElementsMainDiagonal =  SumElementsMainDiagonal(array2d);
Console.WriteLine($"Сумма элементов по диагонали: {sumElementsMainDiagonal}");
