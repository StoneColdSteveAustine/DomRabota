double b1 = ReadInt("Введите b1: ");
double b2 = ReadInt("Введите b2: ");
double k1 = ReadInt("Введите k1: ");
double k2 = ReadInt("Введите k2: ");

double first = (b1 - b2) / (k2 - k1);
double second = (k2 * first) + b2;

Console.WriteLine($"Координаты точки пересечения ({first}:{second})");

double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
