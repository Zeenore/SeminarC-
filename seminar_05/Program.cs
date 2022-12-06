Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());

int result = 0;

for (int i = 1; i <= a; i++)
{
    result += i;

}
Console.WriteLine("Суммв чисел от еденицы до a");
Console.WriteLine(result);