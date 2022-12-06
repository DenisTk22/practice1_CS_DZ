// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А по X и Y: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по X и Y: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

int dif1 = (x1 - x2);
int dif2 = (y1 - y2);
double dist = Math.Sqrt(Math.Pow(dif1, 2) + Math.Pow(dif2, 2));
Console.WriteLine($"Расстояние между точками A и B = {dist:f2}");