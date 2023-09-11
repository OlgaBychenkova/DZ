// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет



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
         Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine(" |");
    }
}

int[,] array2d = CreateMatrixRndInt(4, 5, 1, 9);
PrintMatrix(array2d);
Console.WriteLine("Введите номер строки: ");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());

if(rowsNumber <= 0 || columnsNumber <= 0) Console.WriteLine("Некорректный индекс элемента");
 
 if((rowsNumber-1) < array2d.GetLength(0) && (columnsNumber-1) < array2d.GetLength(1))
 {
    Console.WriteLine($"элемент позиции -> {array2d[rowsNumber-1, columnsNumber-1]}");
 }
 else Console.WriteLine($"заданного элемента в массиве нет");
 
 


