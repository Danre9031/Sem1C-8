int n = Input("Введите размерность массива: ");
int[,] array=new int[n,n];

int number=1;
int i = 0;
int j = 0;

while(number <= n*n)
{
    array[i,j]= number;

    if(i<=j+1 && i+j <n-1)
        ++j;
    else if (i<j && i+j>=n-1)
        ++i;
    else if (i>=j && i+j>n-1)
        --j;
    else
        --i;
    ++number;
}

for(int x = 0; x < array.GetLength(0); x++)
{
        for(int y = 0; y < array.GetLength(1); y++)
        {
            Console.Write(array[x,y]+ " ");
        }
    Console.WriteLine();
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}