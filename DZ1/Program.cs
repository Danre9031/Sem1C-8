
int colCount = Input("m= ");
int rowCount = Input("n= ");

int[,] arr = new int[colCount, rowCount];
int[] row = new int[colCount];

FillSeccondsRandomArrayNumbers (arr);
Console.WriteLine("Исходный массив");
PrintSeccondArray(arr);

Console.WriteLine("Сортировка по строкам: ");

for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < colCount; j++)
    {
        row[j] = arr[i, j];
    }
    BubbleSort(row);
    Insert(i, row, arr);
}

PrintSeccondArray(arr);

void Insert(int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        dest[dim, k] = source[k];
    }
}

void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
    }
}

void FillSeccondsRandomArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
}
void PrintSeccondArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}