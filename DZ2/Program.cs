int colCount = Input("m= ");
int rowCount = Input("n= ");
int[,] firstArray = new int[colCount, rowCount];
int[] rowArray = new int[colCount];

if (colCount == rowCount)
{
    Console.WriteLine("Она квадратная");
}
else
{
    FillSeccondsRandomArrayNumbers(firstArray);
    Console.WriteLine();
    PrintSeccondArrayMain(firstArray);
    Console.WriteLine();
    
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        int summ = 0;
        int size = firstArray.GetLength(1);
        for (int j = 0; j <= size; j++)
        {
            if (j == size)
            {
                rowArray[i] += summ;
            }
            else summ += firstArray[i, j];
        }
    }

    Console.WriteLine();

    PrintMinCol(firstArray, ArrayMinNumber(rowArray));
}

int ArrayMinNumber(int[] array)
{
    int minI = int.MaxValue;
    int min = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] <= min)
        {
            minI = i;
            min = array[i];
        }
    }
    Console.Write($"Строка={minI + 1},сумма {min}, числа в строке:  ");
    return minI;

}
void FillSeccondsRandomArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintSeccondArrayMain(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
void PrintMinCol(int[,] array, int minI)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == minI)
            {
                Console.Write(array[i, j] + " ");
            }
        }

    }
}
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}