// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵); 2, 4 -> 16

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int GetDegree(int num1, int num2)
{
    int a1 = num1;
    int count = 1;
    while (count < num2)
    {
        num1 = num1 * a1;
        count = count + 1;
    }
    return num1;
}

int a = ReadInt("Введите певрое число");
int b = ReadInt("Введите второе число");

int result = GetDegree(a, b);
Console.WriteLine($"{a} в степени {b} = {result}");