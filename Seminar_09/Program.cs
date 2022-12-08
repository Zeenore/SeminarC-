// Напишите программу замены элементов массива:
// положительные элементы заменить на соответствующие отрицательные
// и наоборот
// [-4, -8, 8, 2] [4, 8, -8, 2]



int[] array = {-4, -8, 8, 2};


int[] ElementZamena(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}

void Print(int[] arra)
{
    for (int i = 0; i < arra.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arra.Length - 1) Console.Write(arra[i] + ",");
        else Console.Write(arra[i] + "]");
    }
}
void Print2(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.WriteLine(ar[i]);
    }
}
int[] array1 = ElementZamena(array);
Print2(array);
Print(array1);
