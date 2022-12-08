int[] CreatArrayRandomIntFill(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
        
    }
    return arr;
}


int[] SummaOtricatAndPolojt(int[] arr)
{
    int summaPolojit = 0;
    int summaOtricat = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            summaOtricat = summaOtricat + arr[i];
        }
        else
        {
            summaPolojit += arr[i];
        }
    }
    return new int[]{summaPolojit, summaOtricat};
}
void PrintArray(int[] arraya)
{
    for (int i = 0; i < arraya.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arraya.Length - 1) Console.Write(arraya[i] + ",");
        else Console.Write(arraya[i] + "]");
    }
}

int[] array = CreatArrayRandomIntFill(24, -50, 50);
PrintArray(array);
int[] sumPolojitOtricat = SummaOtricatAndPolojt(array);
Console.WriteLine();
PrintArray(sumPolojitOtricat);

