// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7

Console.Write("Введите число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10 && number <= 99)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"В числе {number} наибольшей цифрой является {firstDigit}.");
    }
    else
    {
        Console.WriteLine($"В числе {number} наибольшей цифрой является {secondDigit}.");
    }
}
else
{
    Console.WriteLine($"Число {number} не входит в отвезок от 10 до 99.");
}