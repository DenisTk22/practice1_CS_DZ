// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

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

int Counter(int k, int[,] matr)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - число строк
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] == k)
                {
                    count +=1;
                }
            } 
        }
        return count;
    //Console.WriteLine($"Элемент {k} встретился {count} раз");
}

int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();
for (int k = 0; k <= 9; k++)
{
    int count = Counter(k, matrix);
    Console.WriteLine($"Элемент {k} встретился {count} раз");
}

/*
другой вариант
void PrintRepeats(int [,] matr)
{
    int [] counter = new int [9];
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - число строк ( ось x)
        {
            for (int j = 0; j < matr.GetLength(1); j++) // GetLength(1) - число столбцов (ось y)
            {
                counters[matr[i,j]]++;
            } 
        }
}

for (int i = 0; i < counters.Length; i++)
{
    if (counters[i] > 0)
    {
        Console.WriteLine($"Элемент {i} повторяется {counters[i]} раз")
    }
}
*/