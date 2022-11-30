//Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); // конвертирование значения введенного в виде строки в консоль от пользователя в число типа int

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (max < number2)
    {
        max = number2;
    }

if (max < number3)
    {
        max = number3;
    }

 Console.WriteLine("Максимальное число из" + " " + number1 + ", " + number2 + ", " + number3 + " : " + max);