// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] MultyMatrix(int[,] anymatr1, int[,] anymatr2)
{   
    int[,] multymat = new int[anymatr1.GetLength(0), anymatr1.GetLength(1)];
    for (int i = 0; i < anymatr1.GetLength(0); i++) // GetLength(0) - число строк ( ось x)
        {
            for (int j = 0; j < anymatr1.GetLength(1); j++) // GetLength(1) - число столбцов (ось y)
            {
                multymat[i,j] = anymatr1[i, j] * anymatr2[i, j];
            } 
        }
        return multymat;
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix1 = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] multymatrix = MultyMatrix(matrix1, matrix2);
PrintMatrix(multymatrix);