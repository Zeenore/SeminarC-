// Напишите программу которая принимает на вход число и выдает кол-во цифр в числе
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

void Natural(int n)
{
    if (n != 0)
    {
        int i = 0;
        while (n != 0)
        {
            n = n / 10;
            i++;

        }
        Console.WriteLine($"Кол-во цифр в числе {i}");
    }
}
Natural(num);