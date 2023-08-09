// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

PrintThirdDigital(number);

void PrintThirdDigital(int num)
{  
    if (num < 100)
    {
        Console.WriteLine("$ Третьей цифры нет");
    }
    else
    {
        while (num > 999)
        {
            num = Convert.ToInt32(Math.Floor(Convert.ToDouble(num / 10)));
        }
        int result = num % 10;
        Console.WriteLine($"Третье число: {result}");
    }
}    



    

    
     


