// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.452 -> 11; 82 -> 10; 9012 -> 12

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}


