// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrom(int numb)
{
    int first = numb / 10000;
    int second = numb / 1000 % 10;
    int fourth = numb / 10 % 10;
    int fifth = numb % 10;
    return first == fifth && second == fourth;
}

Console.WriteLine("Введите пятизначное число > ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 9999 || number > 99999)
{
    Console.WriteLine($"Вы ввели не пятизначное число, повторите попытку "); 
    number = Convert.ToInt32(Console.ReadLine());
    
}
else 
{
    bool result = Palindrom(number);
    Console.WriteLine(result ? "Да" : "Нет");
}
  
