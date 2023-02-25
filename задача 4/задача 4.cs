Console.WriteLine("Введите число а");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int numberC = Convert.ToInt32(Console.ReadLine());
int Max=numberA;
if  (numberB>Max) Max=numberB;
if  (numberC>Max) Max=numberC;

Console.Write($"Наибольшее число {Max}");