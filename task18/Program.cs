// Задача №18. Напишите программу, которая принимает на вход номер четверти и выдает координаты точки которая находится в этой четверти

Console.WriteLine("Введите номер четверти (1, 2, 3 или 4): ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("Координаты первой четверти: X > 0, Y > 0");
}
else if (num == 2)
{
    Console.WriteLine("Координаты второй четверти: X < 0, Y > 0");
}
else if (num == 3)
{
    Console.WriteLine("Координаты третьей четверти: X < 0, Y < 0");
}
else if (num == 4)
{
    Console.WriteLine("Координаты четвертой четверти: X > 0, Y < 0");
}
else //(num < 1 || num > 4);
{
    Console.WriteLine("Нет такой четверти, введите значения от 1 до 4");
}