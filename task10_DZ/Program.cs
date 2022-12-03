// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.456 -> 5; 782 -> 8; 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (num < 100 || num > 999)
{
    Console.WriteLine("Введенное число не трехзначное!");
}
else
{
    int digit2 = num / 10;
    digit2 = digit2 % 10;
    Console.WriteLine($"Вторая цифра вашего числа: {digit2}");
}

