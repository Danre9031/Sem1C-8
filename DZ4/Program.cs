int x = Input("Введите размерность оси X: ");
int y = Input("Введите размерность оси Y: ");
int z = Input("Введите размерность оси Z: ");
Console.WriteLine();
int countNumbers = 89;

if(x * y * z > countNumbers)
{
    Console.WriteLine("Массив слишком большой!");
    return;
}

int[,,] array = CreateArray(x, y, z);

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"[{i},{j},{k}] {array[i, j, k]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] CreateArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] digitValues = new int[countNumbers];
    int value = 10;
    for(int i = 0; i < digitValues.Length; i++)
        digitValues[i] = value++;

    for(int i = 0; i < digitValues.Length; i++)
    {
        int randomIndex = new Random().Next(0, digitValues.Length);
        int temp = digitValues[i];
        digitValues[i] = digitValues[randomIndex];
        digitValues[randomIndex] = temp;
    }

    int valueIndex = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = digitValues[valueIndex++];
            }
        }
    }

    return array;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}