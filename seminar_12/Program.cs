int[] CARndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for ( int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
void NewReverseArray(int[] arra)
{
    int size = arra.Length;
    int index1 = 0;
    int index2 = size- 1;
    while (index1 < index2)
    {
        int obj = arra[index1];
        arra[index1] = arra[index2];
        arra[index2] = obj;
        index1++;
        index2--;
    }
}
int[] array = CARndInt(5, 1, 9);
PrintArr(array);
NewReverseArray(array);
Console.WriteLine();
PrintArr(array);