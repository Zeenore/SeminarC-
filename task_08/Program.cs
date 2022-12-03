Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
{
    Console.WriteLine($"{a} и {b} кратно");  
}
else Console.WriteLine($"Не кратно остаток {a % b}");

