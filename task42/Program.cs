// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101; 3 -> 11; 2 -> 10

// int ReadInt(string massage)
// {
//     Console.WriteLine(massage); 
//     return Convert.ToInt32(Console.ReadLine());
// }

// int num = ReadInt("Введите число: ");

// int numd = num;
// int i = 1;
// for (; numd != 0; i++)
// {
//     numd = numd/2;
// }
// int[] arr = new int[i];
// for (; num != 0; i--)
// {
//     arr[i-1] = num%2;
// }

// Console.WriteLine(string.Join(" ", arr));


// Через рекурсию

int number = 45;

PrintBinaryView(number);

void PrintBinaryView(int n)
{
    if (n <= 0) return; // return - выход из метода
    PrintBinaryView(n/2); // в рекурсии, пока не выполнится полностью команда, ко следующей команде перехода не будет
    Console.Write(n%2);
}