int[,] CreatMatrixRandomInt(int m, int n, int min, int max)
{
    int[,] arr = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            arr[i, k] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

int[,] MatrixChetnostb(int[,] arra)
{
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int k = 0; k < arra.GetLength(1); k++)
        {
            if (i % 2 == 0 && k % 2 == 0); arra[i,k] = arra[i,k] * arra[i,k];
        }
    }
    return arra;
}


void PrintMatrix(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arry.GetLength(1) - 1) Console.Write(arry[i,j] + ",");
            else Console.Write(arry[i,j] + "]");
        }
        Console.WriteLine();
    }
}
int[,] result = CreatMatrixRandomInt(3,4,1,23);
PrintMatrix(result);
Console.WriteLine();
result = MatrixChetnostb(result);
PrintMatrix(result);