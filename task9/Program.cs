﻿// // Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:78 -> 8; 12-> 2; 85 -> 8

int number = new Random().Next(10, 100); //Next работате что первое число входит дапозон, а последнее нет

int digit2 = number % 10; // выявление второй цифры в числе
int digit1 = number / 10; // выявление первой цифры в числе - идет целочисленное деление, берется только целая часть
//Console.WriteLine("Случайное число = " + number + "Первая цифра = " + digit1 + "Первая цифра = " + digit2);
Console.WriteLine($"Случайное число = {number}, Первая цифра = {digit1}, Вторая цифра = {digit2}");
int max = digit1;
if(max < digit2)
{
    max = digit2;
}
Console.WriteLine(max);