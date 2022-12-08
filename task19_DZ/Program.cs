// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 14212 -> нет; 12821 -> да; 23432 -> да

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int mynum = num;
int revN = 0;
while (num > 0)
{
    revN = revN * 10 + num % 10;
    num = num / 10;
}

if (mynum - revN == 0)
{
    Console.WriteLine("Ваше число палиндром");
}
else 
{
    Console.WriteLine("Число как число");
}