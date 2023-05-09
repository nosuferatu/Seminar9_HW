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


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Например:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

SumFromMToN(numberM, numberN);

void SumFromMToN(int numberM, int numberN)
{
    Console.Write(SumMN(numberM - 1, numberN));
}

int SumMN(int numberM, int numberN)
{
    int res = numberM;
    if (numberM == numberN)
        return 0;
    else
    {
        numberM++;
        res = numberM + SumMN(numberM, numberN);
        return res;
    }
}