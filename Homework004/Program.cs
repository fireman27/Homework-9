// Написать программу возведения числа А в целую стень B
int DegreeNumber(int a, int b)
{
    if (b == 1) return a;
    return a * DegreeNumber(a, b - 1);     
}

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень числа А: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Число А возведенное в степень B = {DegreeNumber(a,b)}");  
