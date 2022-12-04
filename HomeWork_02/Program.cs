// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите свое число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Whilee(int n)
{
    int i = 1;
    while(i <= n)
    {
        Console.WriteLine($"куб числа {i} = {Math.Pow(i, 3)}");
        i++;
    }
}
Whilee(num); // Решил задачу с помощью метода void и цикла while, в моем репозитории на GitHub есть ещё 3 варианта решения 
             // через цикл for и вложенного цикла while.