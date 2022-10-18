  // Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.WriteLine("Введите 2 числа, чтобы понять какое больше,а какое меньше");
Console.Write ("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int max=0;
int min=0;
if (numberA > numberB)
{ 
  Console.WriteLine(max= max + numberA);

  Console.WriteLine(min = min + numberB);
}
else
{
   Console.WriteLine(max = max + numberB);
   Console.WriteLine(min = min + numberA);
}