   //  Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа, чтобы понять какое самое большое из трех");
Console.Write ("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());
int max=numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine("Max:" +max);
