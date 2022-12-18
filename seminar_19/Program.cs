Console.Clear();
Console.WriteLine("Задайте число от:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число до:");
int n = Convert.ToInt32(Console.ReadLine());

void Lol(int mo, int no)
{
    if (no == mo - 1) return;
    Lol(mo, no - 1);
    Console.Write($"{no} ");
}
Lol(m, n);
