// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num);

Console.WriteLine("Вторая цифра этого числа");
Console.Write(str[1]);