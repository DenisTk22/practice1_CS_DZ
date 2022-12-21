// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetMatrix(int rows, int columns, int leftRange=0, int rightRange=10) // для leftRange=0 и rightRange=10 заданы параметры по умолчанию
{
    int[,] matr = new int[rows, columns];
        for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - число строк
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = i + j;
            } 
        }
    return matr;
}

void PrintMatrix(int[,] matr) // для вывода двумерного массива, string.Join не подойдет
{
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - число строк ( ось x)
        {
            Console.WriteLine(); // для переноса строк массива
            for (int j = 0; j < matr.GetLength(1); j++) // GetLength(1) - число столбцов (ось y)
            {
                Console.Write(matr[i, j] + " ");
            } 
        }
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetMatrix(rowsCount, columnCount);
PrintMatrix(matrix);