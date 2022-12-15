// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

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
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

int sumChet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (i % 2 != 0)
        {
            sum = sum +array[i];
        }
    }
    return sum;
}

int l = ReadInt("Введите длину массива: ");

int[] massive = GetRandomArray(l);
Console.WriteLine($"Случайный массив из {l} элементов: {string.Join(", ", massive)}");

int sumCh = sumChet(massive);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {sumCh}");

