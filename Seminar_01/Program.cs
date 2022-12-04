Console.WriteLine("Введите координату x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 && y !=0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1 Четверть");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine("3 четверть");       
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("2 четверть");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine("4 четверть");
    }
}

