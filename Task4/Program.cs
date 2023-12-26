// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.Write("Введите натуральное число N: ");
string number = Console.ReadLine();
for (int i = 0; i < number.Length; i++)
{
    if (i == number.Length - 1)
    {
        Console.Write(number[i]);
    }
    else
    {
        Console.Write(number[i] + ", ");
    }
}