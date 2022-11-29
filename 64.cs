Console.WriteLine("Введите натуральное число :");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

void CountDown (int n)
{
    if (n < 0)
    Console.WriteLine($"{n} - ненатуральное число");
    if (n == 0) 
    return;
    Console.Write(n);
    CountDown (n - 1);
}
CountDown(n); 
