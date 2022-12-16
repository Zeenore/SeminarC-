double[,] NewMatrixRandomDoubels(int m, int n, int min, int max)
{
    double[,] array = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i,k] = rnd.Next(min, max + 1);
        }
    }
    return array;
}


void PrintMatrix(double[,] arra)
{
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arra.GetLength(1) - 1) Console.Write(arra[i,j] + "  ");
            else Console.Write(arra[i,j] + "]");
        }
        Console.WriteLine();
    }
}
double[,] ar = NewMatrixRandomDoubels(4, 5, 1, 12);
PrintMatrix(ar);