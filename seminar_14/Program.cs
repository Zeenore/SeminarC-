int[,] CreatMatrixRandomInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
void PrintMatrix(int[,] arra)
{
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arra.GetLength(1) - 1) Console.Write(arra[i,j] + ",");
            else Console.Write(arra[i,j] + "]");
        }
        Console.WriteLine();
    }
}

int[,] result = CreatMatrixRandomInt(4, 5, 1, 12);
PrintMatrix(result);
