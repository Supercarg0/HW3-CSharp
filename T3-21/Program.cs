/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.WriteLine("Введите координаты точки A (x, y, z): ");
int XpA = Convert.ToInt32(Console.ReadLine());
int YpA = Convert.ToInt32(Console.ReadLine());
int ZpA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B (x, y, z): ");
int XpB = Convert.ToInt32(Console.ReadLine());
int YpB = Convert.ToInt32(Console.ReadLine());
int ZpB = Convert.ToInt32(Console.ReadLine());
CoordOfPoints(XpA, YpA, ZpA, XpB, YpB, ZpB);

void CoordOfPoints(int XpA, int YpA, int ZpA, int XpB, int YpB, int ZpB)
{
    double res = Math.Sqrt((XpA - XpB) * (XpA - XpB) + (YpA - YpB) * (YpA - YpB) + (ZpA - ZpB) * (ZpA - ZpB));
    Console.WriteLine($"A ({XpA}, {YpA}, {ZpA}); B ({XpB}, {YpB}, {ZpB}) -> {Math.Round(res, 2)}");
}
