// Напишите программу, принимает на вход число и выдает квадрат числе
Console.WriteLine("Введите число: ");
//string answer = Console.ReadLine(); // '123' на входе задаются данные в виде строки, даже если введено число
//int number = Convert.ToInt32(answer); // '123' --> 123 преобразование строки в число
// 3 и 4 строки можно записать в одну строку:
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number*number);