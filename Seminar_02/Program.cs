Console.WriteLine("Введите координату x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());
string FindQuarte(int xc, int yc)
{

    if (xc > 0 && yc > 0) return "1 Четверть";
    if (xc < 0 && yc < 0) return "3 четверть";
    if (xc < 0 && yc > 0) return "2 четверть";
    if (xc > 0 && yc < 0) return "4 четверть";
    return "Введеы некор корд";
}
string result = FindQuarte(x, y);
Console.WriteLine(result);