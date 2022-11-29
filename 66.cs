Console.WriteLine("Введите число M :");
int m = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите число N :");
int n = int.Parse(Console.ReadLine());

void SumOfNumbers (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine ($"Сумма натуральных элементов в промежутке от M до N - {sum}"); 
        return;
    }
    sum = sum + (m++);
    SumOfNumbers (m, n, sum);
}

SumOfNumbers(m, n, 0);
