// Задача 32: Напишите программу                                                                                                                                                                                                 замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetRandomArray(int length, int leftRange, int rightRange) // задание метода для случайного массива
{
    int[] array = new int[length];
    Random rand = new Random();
    for(int i=0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

int [] GetOppositeArray(int[] array)
{
    int [] array1 = new int[array.Length];


    for(int j=0; j < array.Length; j++)
    {
        array1[j] = array[j] * (-1);

    }
    return array1;
}

const int LENGTH = 4;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
int [] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
int [] massive2 = GetOppositeArray(massive);
Console.WriteLine($"{string.Join(", ", massive2)}");