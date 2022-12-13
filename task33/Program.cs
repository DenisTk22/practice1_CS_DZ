// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

//Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

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

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int CompareInt(int com)
{
    
}