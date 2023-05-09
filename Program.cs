// Задача 64: Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Например:
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int numberM, int numberN)
{
    if (numberM <= numberN) return $"{numberM} "+ NumbersRec(numberM + 1, numberN);
    else return string.Empty;
}

Console.WriteLine(NumbersRec(numberM, numberN));