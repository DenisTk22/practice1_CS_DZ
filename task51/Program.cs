// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной

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

int GetSum (int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - число строк
        {
            sum = matr[i, i] + sum;
        }
        return sum;
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();
int result = GetSum(matrix);
Console.WriteLine($"Сумма чисел, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. = {result}");