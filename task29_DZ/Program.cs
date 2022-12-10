// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int [] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = ReadInt($"Введите {i+1}-й элемент из {array.Length}");
}

Console.WriteLine("Ваш массив: " + string.Join(", " , array));