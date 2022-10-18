   //Напишите программу, которая на вход принимает число (N),
 // а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число больше еденицы: ");
int number = Convert.ToInt32(Console.ReadLine());

int x = 2;

if (number> 1)
{
    while (x < number)
    {
        Console.Write(x + " ");
        x += 2;
    }
}
else
{
    Console.WriteLine("Введенное число меньше или равно 1");
    }