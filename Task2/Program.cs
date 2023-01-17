/*Задача 2: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int number = InputInt("Введите трёхзначное число ");

if (ValidateNumberRank3(number))
{
    while (number > 999)
    {
        number = number / 10;
    }
    int thirdRank = number % 10;
    System.Console.WriteLine($"Третья цифра {thirdRank}");
}

bool ValidateNumberRank3(int number)
{
    if (number > 99)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("Третьей цифры нет.");
        return false;
    }
}

int InputInt(string message)
{
    System.Console.WriteLine(message + ">");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}