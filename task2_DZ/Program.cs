// Задача 2. Напишите программу, которая на входе принимает два числа и выдает какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); // конвертирование значения введенного в виде строки в консоль от пользователя в число типа int

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
    {
        Console.WriteLine("Первое число больше второго");
    }
if (number1 < number2)
        {
            Console.WriteLine("Второе число больше первого");
        } 
if (number1 == number2)
    {
        Console.WriteLine("Числа равны");
    }