// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.452 -> 11; 82 -> 10; 9012 -> 12

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int num)
{
    int sum1 = 0;
    int d_int = num;
    while (d_int >= 10)
    {
        num = d_int;
        num = num % 10;
        d_int = d_int / 10;
        sum1 = sum1 + num;
    }
    int sum = sum1 + d_int;
    return sum;
}

int n = ReadInt("Введите число:");

int result = GetSum(n);
Console.WriteLine($"Сумма цифр в числе {n} = {result}");