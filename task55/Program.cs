// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

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

// void NewMatrixMN (int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - число строк
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 matr[i, j] = matr[j, i];
//             } 
//         }
// }

int[,] NewMatrixMN (int [,] sourceM)
{
    int[,] tmatrix = new int[sourceM.GetLength(1), sourceM.GetLength(0)];
    for (int i = 0; i < tmatrix.GetLength(0); i++) // GetLength(0) - число строк
        {
            for (int j = 0; j < tmatrix.GetLength(1); j++)
            {
                tmatrix[i, j] = sourceM[j, i];
            } 
        }
        return tmatrix;
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();

int[,] newMatrix = NewMatrixMN(matrix);
PrintMatrix(newMatrix);