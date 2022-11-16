// Показать натуральные числа от M до N, N и M заданы
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

while(M <= N)
{
    Console.Write($"{M} ");
    M = M + 1;
}