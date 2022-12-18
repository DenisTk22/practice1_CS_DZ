// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]; [6 7 3 6] -> [6 3 7 6]

int[] GetRandomArray(int length, int leftRange, int rightRange) // задание метода для случайного массива
{
    int[] array = new int[length];
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

void Reverse(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++) // количество операций равно половине массива
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}


const int LENGTH = 5; // константы принято писать заглавными буквами
const int LEFTRANGE = 1;
const int RIGHTRANGE = 10;

int [] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"Случайный массив: {string.Join(", ", massive)}");
Console.WriteLine(); // добавляет пустую строку при выводе массива
Reverse(massive);
Console.WriteLine($"Перевернутый массив: {string.Join(", ", massive)}");
