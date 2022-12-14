// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetRandomArray(int length) // задание метода для случайного массива
{
    int[] array = new int[length];
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int sumChet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
        {
            sum = sum +1;
        }
    }
    return sum;
}

int l = ReadInt("Введите длину массива: ");

int[] massive = GetRandomArray(l);
Console.WriteLine($"Случайный массив из {l} элементов: {string.Join(", ", massive)}");

int sumCh = sumChet(massive);
Console.WriteLine($"Количество четных чисел в массиве = {sumCh}");

