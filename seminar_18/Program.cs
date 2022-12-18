Console.Clear();
Console.WriteLine("Задайте число: ");
int num = Convert.ToInt32(Console.ReadLine());


void NaturalNumbers(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    NaturalNumbers(n - 1);
    
}
NaturalNumbers(num);