// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да 

//Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".
//ЗАДАЧА ВЫДАЕТ НЕ ВЕРНЫЙ РЕЗУЛЬТАТ
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(40, 50);
    }
}

void FindDigit(int[] array, int digit)
{
    bool find = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == digit)
        {
            find = true;
        }
    }
    if (find == true)
    {
        Console.WriteLine("Нет");
    }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int [5];
FillArray(array);
Console.WriteLine(string.Join(", ", array)); //Console.WriteLine(string.Join(", ", array2));
FindDigit(array, num);