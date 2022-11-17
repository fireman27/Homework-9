// Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

string NewFibonacci(int a, int b, int N)
{
    if (N !=0)
    {
        --N;
        int sum = a + b;
        return $"{sum} " + NewFibonacci(b, sum, N);
    }
    else return string.Empty;
}

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Первые два элемента: {a} " + $"{b} ");
Console.WriteLine($"Последовательность: {NewFibonacci(a,b,N)}");