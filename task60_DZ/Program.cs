// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int [,,] GetRandom3DMatrix(int rows, int columns, int dep)
{
    int[,,] Depmatr = new int[rows, columns, dep];
        for (int i = 0; i < Depmatr.GetLength(0); i++)
        {
            for (int j = 0; j < Depmatr.GetLength(1); j++)
            {
                for (int k = 0; k < Depmatr.GetLength(2); k++)
                {
                    {
                        Depmatr[i, j, k] = ReadInt("Введите двузначный уникальный элемент массива:");
                    } 
                }
            }
           
        }
    
    return Depmatr;
}
// заполнение массива
// void PrintMatrix(int rows, int columns, int dep)
// {
//     int[,,] anymatr = new int[rows, columns, dep];
//     for (int c = 10; c < 100; c++)
//     {
//         for (int i = 0; i < anymatr.GetLength(0); i++)
//         {
//             Console.WriteLine();
//             for (int j = 0; j < anymatr.GetLength(1); j++)
//             {
//                 Console.WriteLine();
//                 for (int k = 0; k < anymatr.GetLength(2); k++)
//                 {
//                     {
//                         anymatr[i, j, k] = c;
//                         Console.Write($"{anymatr[i, j, k]}" + $"({i},{j},{k})" + " ");
//                     } 
//                 }
//             }
//         }
//     }
// }

void PrintMatrix(int[,,] anymatr)
{
    for (int i = 0; i < anymatr.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < anymatr.GetLength(1); j++)
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

int rowsCount = 2; //ReadInt("Введите число строк:");
int columnCount = 2; // ReadInt("Введите число столбцов:");
int depCount = 2; // ReadInt("Введите глубину матрицы:");
int[,,] depmatrix = GetRandom3DMatrix(rowsCount, columnCount, depCount);
PrintMatrix(depmatrix);
//PrintMatrix(2, 2, 2);