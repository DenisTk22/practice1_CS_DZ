// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetRandomMatrix(int rows, int columns, int leftRange=0, int rightRange=9)
{
    int[,] matr = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - число строк
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = rand.Next(leftRange, rightRange + 1);
            } 
        }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - число строк ( ось x)
        {
            Console.WriteLine();
            for (int j = 0; j < matr.GetLength(1); j++) // GetLength(1) - число столбцов (ось y)
            {
                Console.Write(matr[i, j] + " ");
            } 
        }
}

int [] SumRow (int[,] anymatr)
{   int [] NSum = new int [anymatr.GetLength(0)];
    for (int i = 0; i < anymatr.GetLength(0); i++) // GetLength(0) - число строк
        {
            int sum = 0;
            for (int j = 0; j < anymatr.GetLength(1); j++)
            {
                sum = anymatr[i, j] + sum;
            } 
            
            NSum[i] = sum;
        }
        return NSum;
}

void minSumRow (int[] anymass)
    {
        int imin = 0;
        int min = anymass[0];
        for (int i = 0; i < anymass.Length; i++)
        {
            if (anymass[i] < min)
            {
                min = anymass[i];
                imin = i;
            }
        }
    Console.WriteLine($"Минимальная сумма элементов находится в {imin+1} строке");
    }


int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();
int [] arr = SumRow(matrix);
Console.WriteLine();
Console.WriteLine($"Сумма по строкам: {string.Join(",", arr)}");
Console.WriteLine();
minSumRow(arr);
