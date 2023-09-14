// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");

    }
}

int[,] CopyMatrix(int[,] matrix)
{
    int[,] NewMatr = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            NewMatr[i, j] = matrix[i, j];
        }
    }
    return NewMatr;
}

int[,] SortRowsMaxToMin(int[,] matrix)
{
    int[,] NewMatr = CopyMatrix(matrix);
    for (int i = 0; i < NewMatr.GetLength(0); i++)
    {
        for (int j = 0; j < NewMatr.GetLength(1); j++)
        {
            for (int n = 0; n < NewMatr.GetLength(1) - 1; n++)
            {
                
                if (NewMatr[i, n] < NewMatr[i, n + 1])
                {
                    int temp = NewMatr[i, n + 1];
                    NewMatr[i, n + 1] = NewMatr[i, n];
                    NewMatr[i, n] = temp;
                }
                
            }
        }
    }
    return NewMatr;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[,] sortRowsMaxToMin = SortRowsMaxToMin(array2d);
PrintMatrix(sortRowsMaxToMin);
