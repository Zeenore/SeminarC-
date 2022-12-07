

int[] array = new int[8];

void RandomArray(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = new Random().Next(0, 2);
        Console.Write(ar[i]);
    }
}
RandomArray(array);