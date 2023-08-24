// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void TableCubes(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine($"{count, 3} -> {count*count*count, 7}");
        count++;
    }
}

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

TableCubes(number);
