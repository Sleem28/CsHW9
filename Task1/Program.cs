//Показать натуральные числа от M до N, N и M заданы
//----------------------------------------------------------------------------------------------------------------------+
void PrintNumbers(int m, int n)
{
    Console.Write(m + " ");
    if(m == n) return;
    m++;
    PrintNumbers(m,n);
}
//----------------------------------------------------------------------------------------------------------------------+
bool numIsNatural = false;
int M = 0, N = 0;
while(!numIsNatural)
{
    Console.Write("Введите число М: ");
    M = int.Parse(Console.ReadLine()?? "");
    if(M>0) 
        numIsNatural = true;
    else
        Console.WriteLine("Число М должно быть натуральным!!! Введите его еще раз.");
}
numIsNatural = false;
while(!numIsNatural)
{
    Console.Write("Введите число N: ");
    N = int.Parse(Console.ReadLine()?? "");
    if(N>0) 
        numIsNatural = true;
    else
        Console.WriteLine("Число N должно быть натуральным!!! Введите его еще раз.");
}


PrintNumbers(M,N);
