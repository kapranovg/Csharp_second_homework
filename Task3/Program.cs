/*Задача 3: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int number = InputInt("Введите число дня недели ");

if (checkWeekDay(number))
{
    if (number == 6 || number == 7)
    {
        System.Console.WriteLine("Это выходной день.");
    }
    else
    {
        System.Console.WriteLine("Это не выходной.");
    }
}

bool checkWeekDay(int num)
{
    if (num > 0 && num < 8)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("Это не день недели.");
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