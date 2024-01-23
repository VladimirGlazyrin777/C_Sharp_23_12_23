//Код не работает!

int[,] CreateMatrix(int rowCount, columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

int[,] matrix CreateMatrix(3,4);
foreach (int e in matrix)
{
    if (isInteresting(e) == true)
    {
        Console.Write($"{e} ");
    }
}

bool isInteresting(int value)
{
    int sumOfDigist = GetSumOfDigits(value);
    if (sumOfDigist % 2 == 0)
    {
        return true;
    }
        return false;
}


int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum +=value % 10;
        value /=10;
    }
    return sum;
}
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}