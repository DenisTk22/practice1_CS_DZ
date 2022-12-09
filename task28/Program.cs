// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 4 -> 24; 5 -> 120

// Метод считывает целое число от пользователя
int ReadInt(string massage) // (1)int ReadInt()
{
    Console.WriteLine(massage); // (1)Console.WriteLine("Введите число"); 
    return Convert.ToInt32(Console.ReadLine());
}
// возвращает произведение от 1 до Number
int GetSumToNumber(int number)
{
    int multy = 1;
    for (int i = 1; i <= number; i++)
    {
        multy *=i; // multy = multy * i
    }
    return multy;
}

int a = ReadInt("Введите число"); //(1)int a = ReadInt();
int result = GetSumToNumber(a);
Console.WriteLine($"Произведение чисел от 1 до {a} = {result}");


