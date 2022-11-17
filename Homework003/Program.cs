// Написать программу вычисления функции Аккермана
int Akk(int n, int m)
{
    if (n == 0) return m + 1;
    else
    if ((n != 0) && (m == 0)) return Akk(n - 1, 1);
    else return Akk(n - 1, Akk(n, m - 1));
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0"); 
Console.WriteLine();
Console.WriteLine(Akk(m, n)); 



