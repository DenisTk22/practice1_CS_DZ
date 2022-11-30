// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int rem = number1%2;

if (rem == 0)
    {
        Console.WriteLine("Данное число четное");
    }
else
    {
        Console.WriteLine("Данное число нечетное");   
    }
        