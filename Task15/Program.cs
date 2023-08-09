// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7)
{
    Console.WriteLine("Некорректное число:");
}
else
{
    bool result = DayOfTheWeek(num);
    Console.WriteLine(result ? "Да" : "Нет");
}
 
bool DayOfTheWeek(int numb)
{
    return numb == 6 || numb == 7;
}

