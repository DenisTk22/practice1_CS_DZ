// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3; Если N = 3 -> 0 1 1; Если N = 7 -> 0 1 1 2 3 5 8

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int num = ReadInt("Введите число: ");
//int a = 0;
//int b = 1;
// for (int i = 2; i < num; i++)
// {
//     Console.WriteLine($"Числа Фибоначи: {i-1 + i-2}");
// }



int[] array = new int [num];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < num; i++)
{
    array[i] = array[i-1] + array[i-2];
}
Console.WriteLine($"{string.Join(",", array)}");