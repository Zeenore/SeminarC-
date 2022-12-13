Console.Clear();
Console.WriteLine("Введите число: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


int NumberUpZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    return count;
}
NumberUpZero(arr);
 int result = NumberUpZero(arr);
 Console.WriteLine($"Кол-во введённых числе больше 0 -> {result}");






