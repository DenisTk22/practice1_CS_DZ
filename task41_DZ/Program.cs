// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 4

string? ReadStr(string massage)
{
    Console.WriteLine(massage); 
    return Console.ReadLine();
}

int GetQty(string? num)
{
    int qty = 0;
    while (num != "stop")
    {
        int chislo = Convert.ToInt32(num);
        if (chislo > 0)
            {qty = qty + 1;}
        num = ReadStr("Введите число или stop для завершения:");
    }
    return qty;
}

string? str = ReadStr("Введите число или stop для завершения:");
int quantity = GetQty(str);

Console.WriteLine($"Вы ввели {quantity} числа больше нуля.");