Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int [,]arr=new int [rows, columns];
int []sum=new int [columns];
Random ran = new Random();

for (int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        arr[i, j] = ran.Next(0, 100);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<columns; i++)
{
    for(int j=0; j<rows; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i=0; i<columns; i++)
{
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)sum[i]/rows}");
}
