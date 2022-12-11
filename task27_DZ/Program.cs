// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.452 -> 11; 82 -> 10; 9012 -> 12

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int num)
{
    int sum1 = 0;
    int d = num;
    while (d >= 10)
    {
        num = d;
        num = num % 10;
        d = d / 10;
        sum1 = sum1 + num;
    }
    int sum = sum1 + d;
    return sum;
}

int n = ReadInt("Введите число:");

int result = GetSum(n);
Console.WriteLine($"Сумма цифр в числе {n} = {result}");