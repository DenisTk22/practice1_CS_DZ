// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1; [1, 2, 3, 6, 2] -> 0; [10, 11, 12, 13, 14] -> 5

int[] GetRandomArray(int length, int leftRange, int rightRange) // задание метода для случайного массива
{
    int[] array = new int[length];
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

int sumChet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] >= 10 && array[i] <=99)
        {
            sum = sum +1;
        }
    }
    return sum;
}

const int LENGTH = 123;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 150;

int [] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"Случайный массив: {string.Join(", ", massive)}");

int sumCh = sumChet(massive);
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {sumCh}");