// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Метод. Получение числа типа Int из консоли, конвертирование строчного символа в число.
int ReadInt(string massage) 
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}
// Метод. Задание двумерного массива из случайных чисел (от 1 до 9).
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
// Метод. Вывод в консоль полученного двумерного массива.
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
// Метод. Получение среднего арифметического по каждому столбцу.
double[] GetAvg (int[,] matr)
{
    double[] avg = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
        }
        avg[j] = Math.Round(sum / (matr.GetLength(0)), 1);
    } 
    return avg;
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();

double[] avgresult = GetAvg(matrix);
Console.WriteLine($"Среднее арифметическое по каждому столбцу: {string.Join("; ", avgresult)}");