// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

// 1. Сумма положительных элементов
// 2. Сумма отрицательных элементов
(int, int) SumPositiveAndNegative(int[] array) // картеж (int, int)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) // если элемент положительный
        {
            sumPositive += array[i]; // копить положительную сумму
        }
        else
        {
            sumNegative += array[i]; // копим отрицательную сумму
        }
    }
    return(sumPositive, sumNegative); //можно вписать два значения, т.к. объявлено два Int в картеже
}

const int LENGTH = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
//int [] massive = GetRandomArray(12, -9, 9); // можно так для данной задачи
int [] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
(int sumP, int sumN) = SumPositiveAndNegative(massive);
Console.WriteLine($"Сумма положительных элементов = {sumP}, сумма отрицательных элементов = {sumN}");