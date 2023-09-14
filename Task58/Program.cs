// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int columns2 = matrix2.GetLength(1);

    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int k = 0; k < columns1; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 9);
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 9);

Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);

Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);

int columns1 = matrix1.GetLength(0);
int rows2 = matrix2.GetLength(1);

if (columns1 != rows2)
{
    Console.WriteLine("Невозможно выполнить умножение матриц");
}
else
{
    int[,] result = MultiplyMatrices(matrix1, matrix2);
    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(result);
}

