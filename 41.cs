Console.WriteLine("Введите числа через запятую ");
string input = Console.ReadLine();
int result = 0;

int [] numbers = StringToNumbers(input);
PrintArray(numbers);

int[] StringToNumbers(string input)
{
    int countNumbers = CountNumbersInString(input);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            substring += input[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if(input[input.Length - 1] != ',')
    numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}

int CountNumbersInString(string input)
{
    int count;
    if(input[input.Length - 1] == ',')
    count = 0;
    else
    count = 1;

    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
        count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0)
    result++;
}
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 = {result}");
