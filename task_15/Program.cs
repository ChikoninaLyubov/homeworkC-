//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите цифру от 1 до 7:");
string? weekend = Console.ReadLine();
int day = 0;
while(!int.TryParse(weekend, out day) || day <= 1 || day >= 7)
{
    Console.Write("Введите число от 1 до 7: ");
    weekend = Console.ReadLine();
}
if (day >= 6) Console.WriteLine("Это выходной день");
else Console.WriteLine("Это будний день");