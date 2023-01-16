Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine()!;
double a = Convert.ToDouble(numberStr1);

Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine()!;
double b = Convert.ToDouble(numberStr2);

Console.WriteLine("Введите третье число");
string numberStr3 = Console.ReadLine()!;
double c = Convert.ToDouble(numberStr3);

double max = a;

if (b > max)
{ max = b; }

if (c > max)
{ max = c; }

Console.WriteLine($"Максимальное число из трех введенных это: {max}");
