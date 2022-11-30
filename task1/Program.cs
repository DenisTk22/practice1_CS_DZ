// Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго числа: а=25, b=25 --> да/ а=2, b=10 --> нет
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 * number2 == number1)
    Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
