// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.34, 5 -> не кратно, остаток 4; 16, 4 -> кратно
Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 % num2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    int N = num1 % num2;
    Console.WriteLine($"не кратное, остаток {N}");
}
