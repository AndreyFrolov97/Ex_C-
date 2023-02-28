Console.Write("Введите число от 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 7)
{
    if (num == 6 | num == 7) Console.WriteLine("Сегодня выходной");
    else Console.WriteLine("Сегодня рабочий день");
}
else Console.WriteLine("Не верное число");
