int colCount1 = Input("m1= ");
int rowCount1 = Input("n1= ");
int colCount2 = Input("m2= ");
int rowCount2 = Input("n2= ");

//int colCount1 = 2;
//int rowCount1 = 3;
//int colCount2 = 3;
//int rowCount2 = 3;

int[,] firstArray = new int[colCount1, rowCount1];
int[,] secondArray = new int[colCount2, rowCount2];

if (rowCount1 != colCount2)
{
    Console.WriteLine("Нельзя умножить матрицы");
}
else
{
    int[,] resultArray = new int[colCount1,rowCount2];

    FillSeccondsRandomArrayNumbers(firstArray);
    Console.WriteLine("Матрица А");
    PrintSeccondArrayMain(firstArray);
    Console.WriteLine();
    FillSeccondsRandomArrayNumbers(secondArray);
    Console.WriteLine("Матрица B");
    PrintSeccondArrayMain(secondArray);
    Console.WriteLine();
    
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        int size = secondArray.GetLength(1);
        for (int j = 0; j < size; j++)
        {
            resultArray[i,j] =0;
            for (int k = 0;k<size;k++)
            {
                resultArray[i,j] += firstArray[i,k]*secondArray[k,j];
            }
        }
    }

    Console.WriteLine("Умножение матриц A*B:");

    PrintSeccondArrayMain(resultArray);
}

void FillSeccondsRandomArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 8);
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

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}