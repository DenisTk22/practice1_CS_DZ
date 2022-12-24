// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetRandomMatrix(int rows, int columns, int leftRange=0, int rightRange=9) // параметры по умолчанию
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


int[,] GetNewM (int[,] sourceMatrix)
{
    int min = sourceMatrix[0, 0];
    int mini = 0;
    int minj = 0;
    for (int i = 0; i < sourceMatrix.GetLength(0); i++) // GetLength(0) - число строк
        {
            for (int j = 0; j < sourceMatrix.GetLength(1); j++)
            {
                if (sourceMatrix[i, j] < min)
                {
                    mini = i;
                    minj = j;
                    min = sourceMatrix[i, j];
                }
            } 
        }
    int[,] newMatrix = new int[sourceMatrix.GetLength(0) - 1, sourceMatrix.GetLength(1) - 1];
    int rowoffset = 0;
    int columnoffset = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++) // GetLength(0) - число строк
        {
            if (i == mini) rowoffset =1;
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                if (j == minj) columnoffset = 1;
                newMatrix[i, j] = sourceMatrix[i + rowoffset, j + columnoffset];
            } 
            columnoffset = 0;
        }
    return newMatrix;
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();
int[,] newmatrix = GetNewM(matrix);
PrintMatrix(newmatrix);



