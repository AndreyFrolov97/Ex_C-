// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int numDigit = 3;

 if (numDigit <= 3)
{
    Console.WriteLine("Ошибка. Введено некорректное число.");
}
else
{
    if (numDigit > 3)
    {
        num = num / Convert.ToInt32(Math.Pow(10, numDigit - 3)); 
    }
    num = num / 10 % 10;
    Console.WriteLine($"Вторая цифра введённого числа: {num}");
}
