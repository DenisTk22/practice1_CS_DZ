// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int [,,] GetRandom3DMatrix(int rows, int columns, int dep, int leftRange=10, int rightRange=99) // параметры по умолчанию
{
    int[,,] Depmatr = new int[rows, columns, dep];
    var rand = new Random(); 
    for (int i = 0; i < Depmatr.GetLength(0); i++) // GetLength(0) - число строк
        {
            for (int j = 0; j < Depmatr.GetLength(1); j++)
            {
                for (int k = 0; k < Depmatr.GetLength(2); k++)
                {
                    {
                        Depmatr[i, j, k] = rand.Next(leftRange, rightRange + 1);
                    } 
                }
            }
           
        }
    return Depmatr;
}

void PrintMatrix(int[,,] anymatr) // для вывода двумерного массива, string.Join не подойдет
{
    for (int i = 0; i < anymatr.GetLength(0); i++) // GetLength(0) - число строк ( ось x)
        {
            Console.WriteLine();
            for (int j = 0; j < anymatr.GetLength(1); j++) // GetLength(1) - число столбцов (ось y)
            {
                Console.WriteLine();
                for (int k = 0; k < anymatr.GetLength(2); k++)
                {
                    {
                        Console.Write($"{anymatr[i, j, k]}" + $"({i},{j},{k})" + " ");
                    } 
                }
            }
        }
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int depCount = ReadInt("Введите глубину матрицы:");
int[,,] depmatrix = GetRandom3DMatrix(rowsCount, columnCount, depCount);
PrintMatrix(depmatrix);