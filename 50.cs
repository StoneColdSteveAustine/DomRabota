Console.WriteLine("Задайте число строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
int count = 0;
Random rnd = new Random();
void PrintArray(int[,] matr)
{ 
    for (int i = 0; i < rows; i++)
    { 
     for (int j = 0; j < columns; j++)
     { 
      Console.Write($"{matr[i, j]} ");
     }
     Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{ 
    for (int i = 0; i < rows; i++)
    { 
        for (int j = 0; j < columns; j++)
        { 
            matr[i,j] = Convert.ToInt32 (rnd.Next(0,50));
        }
    }
}
FillArray(array);
Console.WriteLine();
PrintArray(array);

Console.WriteLine("Введите число:");
int value = Convert.ToInt32(Console.ReadLine());
FindIndex(array);
Console.WriteLine(); 
if (count ==0)
{
    Console.WriteLine("Такого числа нет в массиве");
}

void FindIndex(int[,] matr)
{
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
if (array[i, j]==value)
{
Console.WriteLine("Позиция числа : "+ i + "-" + j);
count++;
}
}
}
}
