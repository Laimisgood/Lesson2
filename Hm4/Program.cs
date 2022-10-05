// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Number(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int day = Number("Введите день недели цифрой: ");

if (day == 1)
{
    System.Console.WriteLine($"{day} -> нет");
}
if (day == 2)
{
    System.Console.WriteLine($"{day} -> нет");
}
if (day == 3)
{
    System.Console.WriteLine($"{day} -> нет");
}
if (day == 4)
{
    System.Console.WriteLine($"{day} -> нет");
}
if (day == 5)
{
    System.Console.WriteLine($"{day} -> нет");
}
if (day == 6)
{
    System.Console.WriteLine($"{day} -> Выходной!");
}
if (day == 7)
{
    System.Console.WriteLine($"{day} -> Выходной!");
}
if (day <= 0 || day > 7)
{
    System.Console.WriteLine("В неделе всего 7 дней");
}