// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Для нахождения точки пересечения 2х прямых задайте значения b1 и b2:");
double b1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Теперь задайте угловые коэффициенты k1 и k2:");
double k1 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
{Console.WriteLine("Прямые параллельны, точки пересения нет.");}
else
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x + b1;
    Console.WriteLine($"Координаты точки пересечения выших прямых ({x:f1}; {y:f1}).");
}