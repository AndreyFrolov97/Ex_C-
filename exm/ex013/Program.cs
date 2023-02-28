// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numStr = Convert.ToString(num);
int numDigit = numStr.Length;
if (numDigit > 2) Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
else Console.WriteLine("третьей цифры нет");
