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


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Например:
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(numberM, numberN);

void AkkermanFunction(int numberM, int numberN)
{
    Console.Write($"A(m,n) = {Akkerman(numberM, numberN)}"); 
}

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0 && numberM > 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    else
    {
        return (Akkerman(numberM - 1, Akkerman(numberM, numberN - 1)));
    }
}