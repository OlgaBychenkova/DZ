// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 01123
// Если N = 3 -> 011
// Если N = 7 -> 0112358



int[] FiboArray (int num)
{
    int[] array = new int[num];
    // array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


Console.WriteLine("Введите число больше 2: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] fiboArray = FiboArray(number);
PrintArray(fiboArray);
