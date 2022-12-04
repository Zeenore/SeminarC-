// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

void Trhee(int num)
{
    if (num > 999 ^ num < 100)
    {
        Console.WriteLine("Ваше число не является трехзначным");
    }
    else
    {
        int second_digit = (num / 10) % 10;
        Console.WriteLine(second_digit);
    }
}
Trhee(n);
// Решил задачу методом void с помощью условного оператора или ^, создал переменную second_digit и запихнул в неё значение выражения 