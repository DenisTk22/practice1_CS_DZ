// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetRandomMatrix(int rows, int columns, int leftRange=0, int rightRange=9) // параметры по умолчанию
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

void DigitSerching (int[,] matr, int a, int b)
{
    if (a < 0 || b < 0)

    {Console.WriteLine("Индекс не может быть отрицательным. Попробой еще!");}

    else if (a > matr.GetLength(0)-1 || b > matr.GetLength(1)-1)

    {Console.WriteLine($"Элемента с индексами {a} и {b} в массиве нет!");}

       else
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (a == i && b == j)

                {Console.WriteLine($"Искомый элемент: {matr[i,j]}");}
            } 
        }
    }
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();
int I = ReadInt("Введите индекс по строке:");
int J = ReadInt("Введите индекс по столбцу:");
DigitSerching(matrix, I, J);