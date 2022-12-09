// Напишите программу
// Метод считывает целое число от пользователя
int ReadInt(string massage) // (1)int ReadInt()
{
    Console.WriteLine(massage); // (1)Console.WriteLine("Введите число"); 
    return Convert.ToInt32(Console.ReadLine());
}
// возвращает сумму от 1 до Number
int GetSumToNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i; // sum +=i
    }
    return sum;
}

int a = ReadInt("Введите число"); //(1)int a = ReadInt();
int result = GetSumToNumber(a);
Console.WriteLine($"Сумма чисел от 1 до {a} = {result}");
