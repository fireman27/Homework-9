// Найти сумму элементов от M до N, N и M заданы.

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int summ = 0;
while (M <= N)
{
    summ = summ + M;  
    M++;
              
}
Console.WriteLine($"Сумма элементов от M до N равна {summ}");
Console.WriteLine();
   
    
