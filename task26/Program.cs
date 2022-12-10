// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 456 -> 3; 78 -> 2; 89126 -> 5

//Метод считывает целое число от пользователя
int ReadInt(string massage) // (1)int ReadInt()
{
    Console.WriteLine(massage); // (1)Console.WriteLine("Введите число"); 
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountOfDigit(int number)
{
    int count = 0;
    while (number != 0)
    {
        number = number / 10;
        count = count + 1;
    }
    return count;
}

int number = ReadInt("Введите число"); //(1)int a = ReadInt();
int result = GetCountOfDigit(number);
Console.WriteLine(result);

