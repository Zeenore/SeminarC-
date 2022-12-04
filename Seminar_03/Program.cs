Console.WriteLine("Введите номер четверти");
int x = Convert.ToInt32(Console.ReadLine());
string Quarty(int q)
{
    if (q == 1) return ("x больше нуля, y больше нуля");
    if (q == 2) return ("х меньше нуля и у больше нуля");
    if (q == 3) return ("х меньше нуля и у меньше нуля");
    if (q == 4) return ("х больше нуля и у меньше нуля");
    return "Введена не коректная четверть";
}
string result = Quarty(x);
Console.WriteLine(result);