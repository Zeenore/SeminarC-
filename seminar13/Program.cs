// Console.WriteLine("Введите сторону a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сторону b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сторону c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// void ExeTreugolnik(int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b) Console.WriteLine("Треугольник существует");
//     else Console.WriteLine("Треугольник не существует");
// }
// ExeTreugolnik(a, b, c);












// Представить десятичное число в двоичное.


// Console.WriteLine("Введите десятичное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// void NumberInDvoich(int n)
// {
//     int a = 0;
//     int i = 0;
//     int[] b = new int[10];
//     while (n >= 1)
//     {
//         a = n % 2;
//         b[i] = a;
//         n /= 2;
//         Console.Write(a);
//     }
// }
// NumberInDvoich(num);

















// создать последовательность фибоначи 5 -> 0 1 1 2 3
// при два числа 0 1
// Console.Clear();
// Console.WriteLine("Введите число n: ");
// int num = int.Parse(Console.ReadLine());


// void Fibona(int num1)
// {
//     int f1 = 0;
//     int f2 = 1;
//     int f3 = 0;
//     if (num1 < 2)
//     {
//         Console.WriteLine($"Фибоначи для {num1} = ");
//         return;
//     }
//     for (int i = 1; i < num1; i++)
//     {
//         f3 = f2 + f1;

//     }
// }



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


int[] CopyArray(int[] a)
{
    int size = a.Length;
    int[] newarr = new int[size];
    for (int i = 0; i < size; i++)
    {
        newarr[i] = a[i];
    }
    return newarr;
}

int[] array = CARndInt(8, 1, 20);
PrintArr(array);
int[] newArray = CopyArray(array);
Console.WriteLine();
PrintArr(newArray);