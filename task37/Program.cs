// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = {1,2,3,4,5}; // задание метода для случайного массива


int [] array2 = new int[(array.Length+1)/2];

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array[i] * array[array.Length-1-i];
    if (i == array.Length - i -1)
    {
        
    }
}

Console.WriteLine(string.Join(", ", array2));