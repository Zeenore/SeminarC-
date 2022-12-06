int[] arr = { 1, 5, 4, 3, 2, 6, 7 };
void Print(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
Print(arr);
void selectionsort(int[] arra)
{
    for (int i = 0; i < arra.Length; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] < arr[minPosition]) minPosition = j;
        }
        int temp = arra[i];
        arra[i] = arra[minPosition];
        arra[minPosition] = temp;
    }
}
Print(arr);
selectionsort(arr);
Print(arr);