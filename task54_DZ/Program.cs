// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

int[,] NewMassiv (int[,] sourceMatrix)
{
   
    for (int i = 0; i < sourceMatrix.GetLength(0); i++) // GetLength(0) - число строк
        {
            for (int sortedSize = 0; sortedSize < sourceMatrix.GetLength(1)-1; sortedSize++)
            {
                for (int j = 0; j < sourceMatrix.GetLength(1)-1-sortedSize; j++)
                {
                    if (sourceMatrix[i, j] > sourceMatrix[i, j+1])
                    {
                        int temp = sourceMatrix[i, j];
                        sourceMatrix[i, j] = sourceMatrix[i, j+1];
                        sourceMatrix[i, j+1] = temp;
                    } 
                }
            }
        }
    return sourceMatrix;
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix);

Console.WriteLine();
int [,] newmatrix = NewMassiv(matrix);
PrintMatrix(newmatrix);
