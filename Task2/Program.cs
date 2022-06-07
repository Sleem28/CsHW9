// Найти сумму элементов от M до N, N и M заданы
int SumElement(int m, int n)
{
    int sum = m;
    if(m == n) return(sum);
    m++;
    return(sum + SumElement(m,n));
}

//---------------------------------------------------Main----------------------------------------------------------------+
Console.Clear();
Console.Write("Введите число М: ");
int M = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()?? "");

Console.WriteLine($"Сумма элементов от {M} до {N} равна {SumElement(M,N)}.");

