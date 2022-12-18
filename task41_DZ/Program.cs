// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 4

// int ReadInt(string massage)
// {
//     Console.WriteLine(massage); 
//     return Convert.ToInt32(Console.ReadLine());
// }

// int [] array = new int[8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = ReadInt($"Введите {i+1}-й элемент из {array.Length}");
// }

// Console.WriteLine("Ваш массив: " + string.Join(", " , array));


string ReadStr(string massage)
{
    Console.WriteLine(massage); 
    return Console.ReadLine();
}

int GetQty(string num)
{
    int q = 0;
        while (num != "stop")
    {
        int c = Convert.ToInt32(num);
            if (c > 0)
                {q = q + 1;}
        num = ReadStr("Введите число или stop для завершения:");
    }
    return q;
}

string a = ReadStr("Введите число или stop для завершения:");
int qauntity = GetQty(a);

Console.WriteLine($"Вы ввели {qauntity} числа больше нуля");