// Найти сумму элементов от M до N, N и M заданы.

int NumberSum(int M, int N)
{
    if (M < N) return M + NumberSum(M + 1, N);
    return M;
}

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {NumberSum(M,N)}"); 


