// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num);

if (str.Length>2)
{
Console.WriteLine("Третья цифра этого числа "+str[2]);
}
else
{
Console.Write("В числе отстутствует 3 цифра");
}