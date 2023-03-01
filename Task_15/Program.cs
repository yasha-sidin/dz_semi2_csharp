// 
Console.Write("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine());

if (day < 8 && day > 0)
{
    if (day == 6 && day == 7)
    {
        Console.Write("Выходной");
    }
    else
    {
        Console.Write("Не выходной");
    }
}
else
{
    Console.Write("Не день недели");
}
