// Показать натуральные числа от M до N, N и M заданы

string ShowNumbers(int N, int M)
{
    if (N >= M) return ShowNumbers(N-1, M) + $"{N} ";
    else return " ";
}

//Console.Clear();
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(ShowNumbers(N, M));
