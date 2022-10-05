// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

System.Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (value > 99)
{
    if (value < 1000)
    {
        int result1 = value % 10;
        System.Console.WriteLine(result1);
    }
    else
    {
        while (value > 999)
        {
            value = value / 10;
        }
        int result2 = value % 10;
        System.Console.WriteLine(result2);
    }
}
else
{
    System.Console.WriteLine($"{value} -> третьей цифры нет");
}
