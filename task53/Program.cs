// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetRandomMatrix(int rows, int columns, int leftRange=0, int rightRange=10) // параметры по умолчанию
{
    int[,] matr = new int[rows, columns];
    var rand = new Random(); // var дает программе самой определить тип переменной
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - число строк
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = rand.Next(leftRange, rightRange + 1);
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

void NewMatrixOppos(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int temp = matr[0, j];
        matr[0, j] = matr[matr.GetLength(0)-1, j];
        matr[matr.GetLength(0)-1, j] = temp;
    }
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();

NewMatrixOppos(matrix);
PrintMatrix(matrix);

