Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    Console.WriteLine($"квадрат {i} = {i * i}");
    i++;
}