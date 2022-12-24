// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int [,] GetSnail (int n, int m)

{   int[,] snail = new int[n, n];
    int i = 0;
    int j = 0;

    for (int k =1; k <= snail.GetLength(0) * snail.GetLength(1); k++)
    {
    snail[i, j] = k;
    if (i <= j + 1 && i + j < snail.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= snail.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > snail.GetLength(1) - 1)
        j--;
    else
        i--;
    }
    return snail;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write(matr[i, j] + " ");
            } 
        }
}

int n = 4;
int rowsCount = n;
int columnCount = n;
int [,] matrix = GetSnail(rowsCount, columnCount);
PrintMatrix(matrix);
