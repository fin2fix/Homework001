Console.WriteLine("Введите число");
string numberStr1 = Console.ReadLine()!;
int a = Convert.ToInt32(numberStr1);
Console.WriteLine("------------");

for (int i = 2; i <= a; i += 2)
{ Console.Write($" {i} "); }

