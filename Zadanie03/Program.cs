Console.WriteLine("Введите число");
string numberStr1 = Console.ReadLine()!;
int a = Convert.ToInt32(numberStr1);

if (a%2 == 0)
{ Console.WriteLine($"Введенное число {a} - четное"); }
else
{ Console.WriteLine($"Введенное число {a} - нечетное"); }
