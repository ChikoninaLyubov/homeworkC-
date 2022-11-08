//Задача 13: Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите трехзначное число: ");
string? number = Console.ReadLine();
if (int.TryParse(number, out int y))
{
    int depth = number.Length;
    if (y < 0) depth--;
    if (Math.Abs(y) > 99)
    {
        for (int i = depth; i != 3; i--)
        {
            y /= 10;
        }
        y %= 10;
        Console.Write($"Третья цифра введенного числа: {Math.Abs(y)}");
    }
    else Console.Write ("Третьей цифры нет");
}
else Console.Write("Введеное выражение не является числом");
