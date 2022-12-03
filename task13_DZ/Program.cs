// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.645 -> 5; 78 -> третьей цифры нет; 32679 -> 6
Console.WriteLine("Введите число: ");
int num1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int digit = num1;
if (digit < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
    }
else
    {
        while (num1 > 1000)
        {
            digit = num1 / 10;
             num1 = digit;
        }
    int three = digit % 10;
    Console.WriteLine($"Третья цифра вашего числа: {three}");
    }