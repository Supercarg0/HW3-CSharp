/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

int Palind(int Num)
{
    int Res = 0;
    while (Num > 0)
    {
        Res = Res * 10 + Num % 10;
        Num /= 10;
    }
    return Res;
}

try
{
    Console.Write("Введите пятизначное число: ");
    int Num = Convert.ToInt32(Console.ReadLine());
    if (Num == Palind(Num))
    {
        Console.WriteLine($"{Num} -> да");
    }
    else
    {
        Console.WriteLine($"{Num} -> нет");
    }
}
catch
{
    Console.WriteLine("Ошибка ввода! Необходимо вводить пятизначное число цифрами!");
}