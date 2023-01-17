/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int number = InputInt("Введите трёхзначное число ");

if (ValidateNumberRank3(number))
{
    int secondRank = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра числа {number} - {secondRank}");
}

bool ValidateNumberRank3(int num)
{
    if (num > 99 && num < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не трёхзначное.");
    return false;
}

int InputInt (string message)
{
    System.Console.WriteLine(message + ">");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}