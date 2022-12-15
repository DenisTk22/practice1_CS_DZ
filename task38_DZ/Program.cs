// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

(int, int, int) sumChet(int[] array)
{
    int indexmin = 0;
    int indexmax = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[indexmax] < array[i])
        {
            indexmax = i;
        }
    else if (array[indexmin] > array[i])
       {
            indexmin = i;
       }
    }
    int diff = array[indexmax] - array[indexmin];
    return (array[indexmax], array[indexmin], diff);
}

int l = ReadInt("Введите длину массива: ");

int[] massive = GetRandomArray(l);
Console.WriteLine($"Случайный массив из {l} элементов: {string.Join(", ", massive)}");

(int max, int min, int diffCh) = sumChet(massive);
Console.WriteLine($"Разница между максимальным элементом <{max}> и минимальным элементом <{min}> данного массива = {diffCh}");