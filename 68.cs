Console.WriteLine("Введите число M :");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N :");
int n = int.Parse(Console.ReadLine());


int Ackermann (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ackermann (m - 1, 1);
    if (m > 0 && n > 0) return Ackermann (m - 1, Ackermann (m, n - 1));
return Ackermann (m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {Ackermann (m, n)}");
