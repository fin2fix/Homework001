Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine()!;
double a = Convert.ToDouble(numberStr1);

Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine()!;
double b = Convert.ToDouble(numberStr2);

if (a > b)
{
  Console.WriteLine($"Первое число {a} больше второго числа {b}");
}
else
{
  Console.WriteLine($"Второе число {b} больше первого числа {a}");
}