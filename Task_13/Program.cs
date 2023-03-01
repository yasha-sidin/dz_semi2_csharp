// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Напишите любое целое число: ");

int n = int.Parse(Console.ReadLine());
if (n / 100 > 0)
{
    string m = n.ToString();
    int i = 0;
    int number = int.Parse(m[2].ToString());
    Console.WriteLine($"Третья цифра равна {number}");
}
else
{
    Console.WriteLine("Третей цифры нет");
}



// if (result == true)
// {
//     Console.WriteLine($"Третья цифра равна {m[2]}");
// }
// else
// {
//     Console.WriteLine("Третей цифры нет");
// }
