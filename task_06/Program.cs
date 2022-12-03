int num1 = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {num1}");

int first_digit = num1 / 10;
int second_digit = num1 % 10;
if (first_digit > second_digit)
{
    Console.WriteLine($"Наибольная цифра числа {num1} -> {first_digit}");
}
if (second_digit > first_digit)
{
    Console.WriteLine($"Наибольшая цифра числа {num1} -> {second_digit}");
}