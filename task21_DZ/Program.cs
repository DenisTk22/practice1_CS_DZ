// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84; 
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А по X, Y и Z: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по X, Y и Z: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

int dif1 = (x2 - x1);
int dif2 = (y2 - y1);
int dif3 = (z2 - z1);

double dist = Math.Sqrt(Math.Pow(dif1, 2) + Math.Pow(dif2, 2) + Math.Pow(dif3, 2));
Console.WriteLine($"Расстояние между точками A и B = {dist:f2}");