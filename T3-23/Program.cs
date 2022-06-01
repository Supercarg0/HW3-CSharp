/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите любое неотрицательное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{Num} -> ");
if (Num > 0)
{
    for (int i = 1; i <= Num; i++)
    {
        int Res = Convert.ToInt32(Math.Pow(i,3));
        Console.Write(Res);
        if (i != Num)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write(". ");
        }
    }
}
else
{
    Console.WriteLine("Ошибка ввода! Введите любое неотрицательное число!");
}
